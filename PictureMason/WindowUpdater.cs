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
namespace PictureMason
{

	/// <summary>
	/// Window updater. A class that primarily exists to move logic out of GUI classes, especially the MainWindow.
	/// </summary>
	public class WindowUpdater
	{
		public WindowUpdater()
		{
			
		}

		/// <summary>
		/// Notify updater that a new input image was selected.
		/// </summary>
		/// <param name="new_selection">New selection (abspath filename).</param>
		public void InputImageSelectionChanged(String new_selection) {
			
		}
	}
}
