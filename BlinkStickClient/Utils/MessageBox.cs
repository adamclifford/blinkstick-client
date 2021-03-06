#region License
// Copyright 2013 by Agile Innovative Ltd
//
// This file is part of BlinkStick application.
//
// BlinkStick application is free software: you can redistribute 
// it and/or modify it under the terms of the GNU General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or (at your option) 
// any later version.
//		
// BlinkStick application is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
// FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with 
// BlinkStick application. If not, see http://www.gnu.org/licenses/.
#endregion

using System;
using Gtk;

namespace BlinkStickClient.Utils
{
    public static class MessageBox
    {
        public static ResponseType Show(Window parent_window, string msg, MessageType messageType, ButtonsType buttons = ButtonsType.Ok)
        {
            int response = 0;
            using (MessageDialog md = new MessageDialog (parent_window, DialogFlags.Modal, messageType, buttons, msg))
            {
                response = md.Run ();
                md.Destroy();
            }
			
            return (ResponseType) response;
        }
	}
}

