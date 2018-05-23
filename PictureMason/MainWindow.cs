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
		MainTabNotebook.Page = 0;

		SetTilesetSelectorOptions(new List<string>());
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

		try
		{

			foreach (WindowUpdater wu in listeners)
			{
				wu.InputImageSelectionChanged(name);
			}

		}
		catch (Exception exx)
		{
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
	internal void SetInputPixbuf(Pixbuf pixbuf)
	{
		InputImageDisplay.Pixbuf = pixbuf;
		InputImageDisplay.Show();
	}


	/// <summary>
	/// Sets the output image, using a pixbuf.
	/// </summary>
	/// <param name="pixbuf">Pixbuf.</param>
	public void SetOutputPixbuf(Pixbuf pixbuf)
	{
		//.Pixbuf = pixbuf;
		PreviewImageDisplay.Pixbuf = pixbuf;
		PreviewImageDisplay.Show();
	}



	public void SetTilesetSelectorOptions(List<String> options)
	{

		while (TilesetSelector.ActiveText != null)
		{
			System.Console.WriteLine("Removing from cell cound {0}", TilesetSelector.Cells.Length);

			TilesetSelector.RemoveText(0);

		}

		System.Console.WriteLine("AddTilesetSelectorOptions : Loading {0} tilesets.", options.Count);

		foreach (var option in options)
		{
			TilesetSelector.AppendText(option);
			System.Console.WriteLine("Adding cell {0}", option);
		}

		TilesetSelector.InsertText(0, "(None)");
		TilesetSelector.Active = 0;

	}

	/// <summary>
	/// Resize main window to fill out a little more of the screen.
	/// 
	/// </summary>
	public void ResizeToFitScreen()
	{
		var screen = Screen.ActiveWindow.Screen;
		var width = screen.Width;
		var height = screen.Height;

		Resize((int)(width * 0.90) - 50, (int)(height * 0.90) - 50);

	}

	/// <summary>
	/// Resets the divisor positions. This usually means that the message box shrinks to display
	/// the images, and the divisor between both images is set at 50%.
	/// </summary>
	public void ResetDivisorPositions()
	{
		int pane_w = 0;
		int pane_h = 0;

		GetSize(out pane_w, out pane_h);

		TabsheetMsgboxDividor.Position = (int)(pane_h * 0.95) - 10;
		WorkbenchHPaneD.Position = pane_w / 2;
	}

	protected void OnTilesetSelectorChanged(object sender, EventArgs e)
	{
		System.Console.WriteLine("Tileset Changed to {0}", TilesetSelector.ActiveText);
		try
		{

			foreach (WindowUpdater wu in listeners)
			{
				wu.TilesetSelectionChanged(TilesetSelector.ActiveText);
			}

		}

		catch (Exception exx)
		{
			System.Console.WriteLine("Setting tileset caused exception {0} for {1} ", exx.ToString(), TilesetSelector.ActiveText);
		}
	}

	protected void OnInputImageZoomin(object sender, EventArgs e)
	{
		ResetDivisorPositions();
	}
}
