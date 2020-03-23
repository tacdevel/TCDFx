/***********************************************************************************************************************
 * FileName:            Size.cs
 * Copyright/License:   https://github.com/tom-corwin/tacdevlibs/blob/master/LICENSE.md
***********************************************************************************************************************/

using System;
using System.Runtime.InteropServices;

namespace TACDevel.Drawing
{
    /// <summary>
    /// Represents an ordered pair of integers that defines a size in a two-dimensional plane.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Size : IEquatable<Size>
    {
        /// <summary>
        /// Represents a <see cref="Size"/> that has <see cref="Width"/> and <see cref="Height"/> values set to zero.
        /// </summary>
        public static readonly Size Empty = new Size(0, 0);

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class with the specified dimensions.
        /// </summary>
        /// <param name="w">The width component of the point.</param>
        /// <param name="h">The height component of the point.</param>
        public Size(int w, int h)
        {
            Width = w;
            Height = h;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> structure from a <see cref="Point"/>.
        /// </summary>
        /// <param name="pt">A <see cref="Point"/> that specifies the dimensions for the new <see cref="Size"/>.</param>
        public Size(Point pt) : this(pt.X, pt.X) { }

        /// <summary>
        /// Gets or sets the width of this <see cref="Size"/>.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of this <see cref="Size"/>.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Size"/> is empty.
        /// </summary>
        public bool IsEmpty => this == Empty;

        /// <summary>
        /// Adds the specified <see cref="Size"/> to the other specified <see cref="Size"/>.
        /// </summary>
        /// <param name="sz1">The <see cref="Size"/> to be added to.</param>
        /// <param name="sz2">The <see cref="Size"/> to add to <paramref name="sz1"/>.</param>
        /// <returns>The <see cref="Size"/> that is the result of the addition operation.</returns>
        public static Size Add(Size sz1, Size sz2) => new Size(sz1.Width + sz2.Width, sz1.Height + sz2.Height);

        /// <summary>
        /// Subtracts the specified <see cref="Size"/> from the other specified <see cref="Size"/>.
        /// </summary>
        /// <param name="sz1">The <see cref="Size"/> to be subtracted from.</param>
        /// <param name="sz2">The <see cref="Size"/> to subtract from <paramref name="sz1"/>.</param>
        /// <returns>The <see cref="Size"/> that is the result of the addition operation.</returns>
        public static Size Subtract(Size sz1, Size sz2) => new Size(sz1.Width - sz2.Width, sz1.Height - sz2.Height);

        /// <summary>
        /// Converts the specified <see cref="SizeD"/> to a <see cref="Size"/> by rounding the values of the <see cref="SizeD"/> to the next higher integer values.
        /// </summary>
        /// <param name="val">The <see cref="SizeD"/> to convert.</param>
        /// <returns>The <see cref="Size"/> this method converts to.</returns>
        public static Size Ceiling(SizeD val) => new Size((int)Math.Ceiling(val.Width), (int)Math.Ceiling(val.Height));

        /// <summary>
        /// Converts the specified <see cref="SizeD"/> to a <see cref="Size"/> by rounding the values of the <see cref="SizeD"/> to the nearest integer.
        /// </summary>
        /// <param name="val">The <see cref="SizeD"/> to convert.</param>
        /// <returns>The <see cref="Size"/> this method converts to.</returns>
        public static Size Round(SizeD val) => new Size((int)Math.Round(val.Width), (int)Math.Round(val.Height));

        /// <summary>
        /// Converts the specified <see cref="SizeD"/> to a <see cref="Size"/> by truncating the values of the <see cref="SizeD"/>.
        /// </summary>
        /// <param name="val">The <see cref="SizeD"/> to convert.</param>
        /// <returns>The <see cref="Size"/> this converts to.</returns>
        public static Size Truncate(SizeD val) => new Size((int)Math.Truncate(val.Width), (int)Math.Truncate(val.Height));

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The object to compare with the current object.</param>
        /// <returns><see langword="true"/> if the specified object is equal to the current object; otherwise, <see langword="false"/>.
        public bool Equals(Size size) => Width == size.Width && Height == size.Height;

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><see langword="true"/> if the specified object is equal to the current object; otherwise, <see langword="false"/>.
        public override bool Equals(object obj) => !(obj is Size) ? false : Equals((Size)obj);

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode() => unchecked(HashCode.Combine(Width, Height));

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() => $"[Width: {Width}, Height: {Height}]";

        /// <summary>
        /// Adds the specified <see cref="Size"/> to the other specified <see cref="Size"/>.
        /// </summary>
        /// <param name="sz1">The <see cref="Size"/> to be added to.</param>
        /// <param name="sz2">The <see cref="Size"/> to add to <paramref name="sz1"/>.</param>
        /// <returns>The <see cref="Size"/> that is the result of the addition operation.</returns>
        public static Size operator +(Size sz1, Size sz2) => Add(sz1, sz2);

        /// <summary>
        /// Subtracts the specified <see cref="Size"/> from the other specified <see cref="Size"/>.
        /// </summary>
        /// <param name="sz1">The <see cref="Size"/> to be subtracted from.</param>
        /// <param name="sz2">The <see cref="Size"/> to subtract from <paramref name="sz1"/>.</param>
        /// <returns>The <see cref="Size"/> that is the result of the subtraction operation.</returns>
        public static Size operator -(Size sz1, Size sz2) => Subtract(sz1, sz2);

        /// <summary>
        /// Multiplies the specified <see cref="Size"/> by the other specified <see cref="Size"/>.
        /// </summary>
        /// <param name="sz1">The first <see cref="Size"/> to be multiplied.</param>
        /// <param name="sz2">The <see cref="Size"/> to be multiplied by <paramref name="sz1"/>.</param>
        /// <returns>The <see cref="Size"/> that is the result of the multiplication operation.</returns>
        public static Size operator *(Size sz1, Size sz2) => new Size(sz1.Width * sz2.Width, sz1.Height * sz2.Height);

        /// <summary>
        /// Divides the specified <see cref="Size"/> by the other specified <see cref="Size"/>.
        /// </summary>
        /// <param name="sz1">The <see cref="Size"/> to be divided.</param>
        /// <param name="sz2">The <see cref="Size"/> to divide <paramref name="sz1"/> by.</param>
        /// <returns>The <see cref="Size"/> that is the result of the multiplication operation.</returns>
        public static Size operator /(Size sz1, Size sz2) => new Size(sz1.Width / sz2.Width, sz1.Height / sz2.Height);

        /// <summary>
        /// Tests whether two specified <see cref="Size"/> structures are equivalent.
        /// </summary>
        /// <param name="left">The <see cref="Size"/> that is to the left of the equality operator.</param>
        /// <param name="right">The <see cref="Size"/> that is to the right of the equality operator.</param>
        /// <returns><see langword="true"/> if the two <see cref="Size"/> structures are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Size left, Size right) => left.Equals(right);

        /// <summary>
        /// Tests whether two specified <see cref="Size"/> structures are different.
        /// </summary>
        /// <param name="left">The <see cref="Size"/> that is to the left of the inequality operator.</param>
        /// <param name="right">The <see cref="Size"/> that is to the right of the inequality operator.</param>
        /// <returns><see langword="true"/> if the two <see cref="Size"/> structures are different; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Size left, Size right) => !(left == right);

        /// <summary>
        /// Converts the specified <see cref="Size"/> structure to a <see cref="Point"/> structure.
        /// </summary>
        /// <param name="sz">The <see cref="Size"/> to be converted.</param>
        /// <returns>The <see cref="Point"/> that results from the conversion.</returns>
        public static explicit operator Point(Size sz) => new Point(sz);

        /// <summary>
        /// Converts the specified <see cref="Size"/> structure to a <see cref="SizeD"/> structure.
        /// </summary>
        /// <param name="sz">The <see cref="Size"/> to be converted.</param>
        /// <returns>The <see cref="SizeD"/> that results from the conversion.</returns>
        public static explicit operator SizeD(Size sz) => new SizeD(sz.Width, sz.Height);
    }
}