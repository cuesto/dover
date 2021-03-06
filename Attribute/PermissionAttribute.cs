﻿/*
 *  Dover Framework - OpenSource Development framework for SAP Business One
 *  Copyright (C) 2014  Eduardo Piva
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *  
 *  Contact me at <efpiva@gmail.com>
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbobsCOM;

namespace Dover.Framework.Attribute
{    
    /// <summary>
    /// Used to create custom Addin Permission attributes.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    public class PermissionAttribute : System.Attribute
    {
        /// <summary>
        /// Unique ID of the permission
        /// </summary>
        public String PermissionID { get; set; }
        /// <summary>
        /// Display name of the permission.
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// Parent ID of the permission.
        /// </summary>
        public String ParentID { get; set; }        
        /// <summary>
        /// FormType that this permission will restrict. Leave empty if it's not related to any form
        /// </summary>
        public String FormType { get; set; }
        /// <summary>
        /// Access options related to this Permission
        /// </summary>
        public BoUPTOptions Options { get; set; }

        public PermissionAttribute(string PermissionID, string Name, string ParentID,
            string FormType = "", BoUPTOptions Options = BoUPTOptions.bou_FullNone)
        {
            this.PermissionID = PermissionID;
            this.Name = Name;
            this.ParentID = ParentID;
            this.FormType = FormType;
            this.Options = Options;
        }
    }
}
