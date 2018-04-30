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
using Gtk;
using TileExchange.TileSetRepo;
using TileExchange.TileSetTypes;
using TileExchange.ExchangeEngine;
using TileExchange.TesselatedImages;


public partial class MainWindow : Gtk.Window
{

	// Lazy.
	private Boolean NeedsUpdate;
	private String InputImageName;
	private TileSetRepo tsr;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		tsr = new TileSetRepo();
		this.NeedsUpdate = true;
		LazyUpdate();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void ShowAbout(object sender, EventArgs e)
	{
		var about = new AboutDialog();
		about.Run();
		about.Destroy();
	}

	protected void QuitRequested(object sender, EventArgs e)
	{
		Application.Quit();
	}

	// Lazy.
	protected void LazyUpdate() {

		if (!NeedsUpdate) {
			return;
		}

		tsr.Discover();
		var tset = tsr.TileSet(0);
		System.Console.WriteLine("TSR loaded {0} tilesets.", tsr.NumberOfTilesets());

		try {
			
			var buffer = System.IO.File.ReadAllBytes(InputImageName);
			var pixbuf = new Gdk.Pixbuf(buffer);
			var image = new Gtk.Image(pixbuf);

			InputImageDisplay.Pixbuf = pixbuf;
			InputImageDisplay.Show();

		} catch (Exception exx)
		{
			System.Console.WriteLine("LazyUpdate could not update image, caused exception {0} for {1} ", exx.ToString(), InputImageName);
		}

		try {

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



	protected void OnInputImageFileSelectorSelectionChanged(object sender, EventArgs e)
	{
		var aswidget = (Gtk.FileChooserWidget)sender;
		var name = aswidget.Filename;
		System.Console.WriteLine("Setting preview image from {0} with event {1} to filename {2}", sender.ToString(), e.ToString(), name);

		try {
			InputImageName = name;
		} catch (Exception exx) {
			System.Console.WriteLine("Setting image caused exception {0} for {1} ", exx.ToString(), name);
		}

		NeedsUpdate = true;
		LazyUpdate();
	}
}
