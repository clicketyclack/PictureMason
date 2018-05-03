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
		private MainWindow win;

		public WindowUpdater()
		{
			LazyUpdate();

		}

		/// <summary>
		/// Notify updater that a new input image was selected.
		/// </summary>
		/// <param name="new_selection">New selection (abspath filename).</param>
		public void InputImageSelectionChanged(String new_selection) {
			InputImageName = new_selection;
			tsr = new TileSetRepo();
			this.NeedsUpdate = true;

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
				!File.Exists(InputImageName))
			{
				NeedsUpdate = false;
				return;
			}

			tsr.Discover();
			var tset = tsr.TileSet(0);
			System.Console.WriteLine("TSR loaded {0} tilesets.", tsr.NumberOfTilesets());

			try
			{

				var buffer = System.IO.File.ReadAllBytes(InputImageName);
				var pixbuf = new Gdk.Pixbuf(buffer);
				var image = new Gtk.Image(pixbuf);

				win.SetOutputPixbuf(pixbuf);
			

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

				new TileExchange.BasicExchangeEngine((IHueMatchingTileset)tset, loaded_image).run();
				var assembled_bitmap_pre = loaded_image.AssembleFragments();
				writer.WriteBitmap(assembled_bitmap_pre, System.IO.Path.Combine("/tmp", "foo.png"));

			}
			catch (Exception exx)
			{
				System.Console.WriteLine("LazyUpdate could not generate image, caused exception {0} for {1} ", exx.ToString(), InputImageName);
			}


		}

		internal void AddUpdateTarget(MainWindow win)
		{
			this.win = win;
		}
	}
}
