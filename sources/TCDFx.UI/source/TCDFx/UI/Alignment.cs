/***************************************************************************************************
 * FileName:             Alignment.cs
 * Copyright:             Copyright © 2017-2019 Thomas Corwin, et al. All Rights Reserved.
 * License:              https://github.com/tom-corwin/tcdfx/blob/master/LICENSE.md
 **************************************************************************************************/

namespace TCD.UI
{
    /// <summary>
    /// Specifies how content is positioned in an <see cref="GridContainer"/>.
    /// </summary>
    public enum Alignment : long
    {
        /// <summary>
        /// The contents fills the container.
        /// </summary>
        Fill = 0,

        /// <summary>
        /// The contents align in the center of the container.
        /// </summary>
        Center = 1,

        /// <summary>
        /// The contents align toward the top of the container.
        /// </summary>
        Top = 2,

        /// <summary>
        /// The contents align toward the top-left of the container.
        /// </summary>
        TopLeft = 3,

        /// <summary>
        /// The contents align toward the top-center of the container.
        /// </summary>
        TopCenter = 4,

        /// <summary>
        /// The contents align toward the top-right of the container.
        /// </summary>
        TopRight = 5,

        /// <summary>
        /// The contents align toward the left of the container.
        /// </summary>
        Left = 6,

        /// <summary>
        /// The contents align toward the left-center of the container.
        /// </summary>
        LeftCenter = 7,

        /// <summary>
        /// The contents align toward the right of the container.
        /// </summary>
        Right = 8,

        /// <summary>
        /// The contents align toward the right-center of the container.
        /// </summary>
        RightCenter = 9,

        /// <summary>
        /// The contents align toward the bottom of the container.
        /// </summary>
        Bottom = 10,

        /// <summary>
        /// The contents align toward the bottom-left of the container.
        /// </summary>
        BottomLeft = 11,

        /// <summary>
        /// The contents align toward the bottom-center of the container.
        /// </summary>
        BottomCenter = 12,

        /// <summary>
        /// The contents align toward the bottom-right of the container.
        /// </summary>
        BottomRight = 13
    }
}