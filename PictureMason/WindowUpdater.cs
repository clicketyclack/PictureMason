/* 
 * Copyright (C) 2018 Erik Mossberg
 *
 * This file is part of PictureMason.
 *
 * PictureMason is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *  
 * PictureMason is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 * 
 */
using System;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.IO;
using TileExchange.TileSetRepo;
using TileExchange.TileSetTypes;
using TileExchange.TesselatedImages;

namespace PictureMason
{

	/// <summary>
	/// Window updater. A class that primarily exists to move logic out of GUI classes, especially the MainWindow.
	/// </summary>
	public class WindowUpdater
	{

		private Boolean NeedsUpdate;
		private TileSetRepo tsr;
		private String InputImageName;
		private ITileSet TileSet;
		private List<MainWindow> update_targets;

		public WindowUpdater()
		{
			tsr = new TileSetRepo();
			tsr.Discover();
			TileSet = null;
			update_targets = new List<MainWindow>();

		}

		/// <summary>
		/// Notify updater that a new input image was selected.
		/// </summary>
		/// <param name="new_selection">New selection (abspath filename).</param>
		public void InputImageSelectionChanged(String new_selection) {
			InputImageName = new_selection;

			this.NeedsUpdate = true;
			LazyUpdate();
		}

		/// <summary>
		/// Notifies the WindowUpdater that the tileset selection changed.
		/// </summary>
		/// <param name="new_selection">New selection.</param>
		public void TilesetSelectionChanged(String new_selection) {
			var tsets = tsr.ByName(new_selection);
			if (tsets.Count == 1) {
				TileSet = tsets[0];
				this.NeedsUpdate = true;
			}

			LazyUpdate();
		}



		// Lazy.
		protected void LazyUpdate()
		{

			if (!NeedsUpdate)
			{
				return;
			}

			if (InputImageName is null ||
			    TileSet is null ||
				!File.Exists(InputImageName))
			{
				NeedsUpdate = false;
				return;
			}

			System.Console.WriteLine("TSR loaded {0} tilesets.", tsr.NumberOfTilesets());

			try
			{

				var buffer = System.IO.File.ReadAllBytes(InputImageName);
				var pixbuf = new Gdk.Pixbuf(buffer);
				var image = new Gtk.Image(pixbuf);

				foreach (var win in update_targets)
				{
					win.SetInputPixbuf(pixbuf);
				}

			}
			catch (Exception exx)
			{
				System.Console.WriteLine("LazyUpdate could not update image, caused exception {0} for {1} ", exx.ToString(), InputImageName);
			}

			try
			{

				var tesser = new Basic16Tesselator();
				var loader = new TesselatedImageLoader();

				var loaded_image = loader.LoadFromImagelibrary(InputImageName, tesser);
				var writer = new ImageWriter();

				new TileExchange.BasicExchangeEngine((IHueMatchingTileset)TileSet, loaded_image).run();
				var assembled_bitmap_pre = loaded_image.AssembleFragments();
				writer.WriteBitmap(assembled_bitmap_pre, System.IO.Path.Combine("/tmp", "foo.png"));

				MemoryStream ms = new MemoryStream ();

				assembled_bitmap_pre.Save(ms, ImageFormat.Png);
				ms.Position = 0;
				var pixbuf = new Gdk.Pixbuf(ms); 

				update_targets[0].SetOutputPixbuf(pixbuf);


			}
			catch (Exception exx)
			{
				System.Console.WriteLine("LazyUpdate could not generate image, caused exception {0} for {1} ", exx.ToString(), InputImageName);
			}


		}

		/// <summary>
		/// Adds an update target.
		/// </summary>
		/// <param name="new_win">New window.</param>
		internal void AddUpdateTarget(MainWindow new_win)
		{
			try
			{
				this.update_targets.Add(new_win);
				RepopulateTilesetLists();
			} catch (Exception exx) {
				System.Console.WriteLine("AddUpdateTarget could not add Window {0}, caused exception {1} ", new_win, exx.ToString());
			}

		}

		/// <summary>
		/// Repopulates the tileset lists for our update targets.
		/// </summary>
		private void RepopulateTilesetLists() 
		{
			if (update_targets != null && tsr != null) {
				var names = tsr.ListTilesetNames();
				System.Console.WriteLine("RepopulateTilesetLists() will populate {0} tilesets.", names.Count);
				foreach (var win in update_targets)
				{
					win.SetTilesetSelectorOptions(names);
				}
			} else {
				System.Console.WriteLine("RepopulateTilesetLists() skipped as one of win = '{0}' and TileSetRepo = '{1}' is null.", update_targets, tsr);
			}
		}

	}
}
