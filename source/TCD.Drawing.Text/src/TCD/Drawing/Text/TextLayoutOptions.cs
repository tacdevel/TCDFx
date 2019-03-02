﻿/***************************************************************************************************
 * FileName:             TextLayoutOptions.cs
  * Copyright:            Copyright © 2017-2019 Thomas Corwin, et al. All Rights Reserved.
 * License:              https://github.com/tom-corwin/tcdfx/blob/master/LICENSE.md
 **************************************************************************************************/

using static TCD.Native.NativeMethods;

namespace TCD.Drawing
{
    public readonly struct TextLayoutOptions
    {
        internal readonly Libui.uiDrawTextLayoutParams Native;

        public TextLayoutOptions(AttributedText attrText, Font defaultFont, double width, TextAlignment alignment)
        {
            Native = new Libui.uiDrawTextLayoutParams()
            {
                String = attrText,
                DefaultFont = defaultFont.Native,
                Width = width,
                Align = alignment
            };

            Text = attrText;
            DefaultFont = defaultFont;
            Width = width;
            Alignment = alignment;
        }

        public AttributedText Text { get; }
        public Font DefaultFont { get; }
        public double Width { get; }
        public TextAlignment Alignment { get; }
    }
}