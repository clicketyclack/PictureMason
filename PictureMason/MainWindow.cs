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

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
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

	protected void OnInputImageFileSelectorSelectionChanged(object sender, EventArgs e)
	{
		var aswidget = (Gtk.FileChooserWidget)sender;
		var name = aswidget.Filename;
		System.Console.WriteLine("Setting preview image from {0} with event {1} to filename {2}", sender.ToString(), e.ToString(), name);

		try {

			var buffer = System.IO.File.ReadAllBytes(name);
			var pixbuf = new Gdk.Pixbuf(buffer);
			var image = new Gtk.Image(pixbuf);

			InputImageDisplay.Pixbuf = pixbuf;
			InputImageDisplay.Show();
		} catch (Exception exx) {
			System.Console.WriteLine("Setting image caused exception {0} for {1} ", exx.ToString(), name);
		}
	}
}
