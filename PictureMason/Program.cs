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


namespace PictureMason
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			MainWindow win = new MainWindow();
			var update_watcher = new WindowUpdater();
			win.RegisterUpdateWatcher(update_watcher);
			update_watcher.AddUpdateTarget(win);

			win.Show();
			Application.Run();
		}
	}
}
