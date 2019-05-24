/***************************************************************************************************
 * FileName:             PropertyChangingEventArgs.cs
 * Copyright:            Copyright © 2017-2019 Thomas Corwin, et al. All Rights Reserved.
 * License:              https://github.com/tom-corwin/tcdfx/blob/master/LICENSE.md
 **************************************************************************************************/

using System;

namespace TCD.ComponentModel
{
    /// <summary>
    /// Provides data for the <see cref="INotifyPropertyChanging.PropertyChanging"/> event.
    /// </summary>
    public class PropertyChangingEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitializedEventArgs"/> class.
        /// </summary>
        /// <param name="componentName">The name of the property whose value is changing.</param>
        public PropertyChangingEventArgs(string propertyName) => PropertyName = propertyName;

        /// <summary>
        /// Gets the name of the property whose value is changing.
        /// </summary>
        public virtual string PropertyName { get; }
    }
}