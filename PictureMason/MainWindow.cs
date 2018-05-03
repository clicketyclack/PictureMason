﻿/* 
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
using System.Collections.Generic;

using PictureMason;
using Gdk;

public partial class MainWindow : Gtk.Window
{

	private List<WindowUpdater> listeners;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		listeners = new List<WindowUpdater>();
		TilesetSelector.InsertText(0, "(None)");
		TilesetSelector.Active = 0;
		MainTabNotebook.Page = 0;
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void ShowAbout(object sender, EventArgs e)
	{
		var about = new PictureMason.AboutDialog();
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

			foreach (WindowUpdater wu in listeners) {
				wu.InputImageSelectionChanged(name);
			}


		} catch (Exception exx) {
			System.Console.WriteLine("Setting image caused exception {0} for {1} ", exx.ToString(), name);
		}

	}

	internal void RegisterUpdateWatcher(WindowUpdater update_watcher)
	{
		listeners.Add(update_watcher);	
	}

	/// <summary>
	/// Sets the output image, using a pixbuf.
	/// </summary>
	/// <param name="pixbuf">Pixbuf.</param>
	internal void SetOutputPixbuf(Pixbuf pixbuf)
	{
		InputImageDisplay.Pixbuf = pixbuf;
		InputImageDisplay.Show();
	}
}
