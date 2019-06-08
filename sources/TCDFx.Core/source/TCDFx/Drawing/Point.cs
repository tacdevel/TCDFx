/***************************************************************************************************
 * FileName:             Point.cs
 * Copyright:            Copyright © 2017-2019 Thomas Corwin, et al. All Rights Reserved.
 * License:              https://github.com/tom-corwin/tcdfx/blob/master/LICENSE.md
 **************************************************************************************************/

using System;
using System.Runtime.InteropServices;
using TCDFx.Numerics.Hashing;

namespace TCDFx.Drawing
{
    /// <summary>
    /// Represents an ordered pair of integer x- and y-coordinates that defines a point in a two-dimensional plane.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Point : IEquatable<Point>
    {
        /// <summary>
        /// Represents an uninitialized <see cref="Point"/>.
        /// </summary>
        public static readonly Point Empty = new Point();

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with the specified coordinates.
        /// </summary>
        /// <param name="x">The horizontal position of the point.</param>
        /// <param name="y">The vertical position of the point.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> structure from a <see cref="Size"/>.
        /// </summary>
        /// <param name="sz">A <see cref="Size"/> that specifies the coordinates for the new <see cref="Point"/>.</param>
        public Point(Size sz) : this(sz.Width, sz.Height) { }

        /// <summary>
        /// Gets or sets the x-coordinate of this <see cref="Point"/>.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of this <see cref="Point"/>.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Point"/> is empty.
        /// </summary>
        public bool IsEmpty => this == Empty;

        /// <summary>
        /// Adds the specified <see cref="Size"/> to the specified <see cref="Point"/>.
        /// </summary>
        /// <param name="pt">The <see cref="Point"/> to add.</param>
        /// <param name="sz">The <see cref="Size"/> to add.</param>
        /// <returns>The <see cref="Point"/> that is the result of the addition operation.</returns>
        public static Point Add(Point pt, Size sz) => new Point(pt.X + sz.Width, pt.Y + sz.Height);

        /// <summary>
        /// Returns the result of subtracting the specified <see cref="Size"/> from the specified <see cref="Point"/>.
        /// </summary>
        /// <param name="pt">The <see cref="Point"/> to be subtracted from.</param>
        /// <param name="sz">The <see cref="Size"/> to subtract from <paramref name="pt"/>.</param>
        /// <returns>The <see cref="Point"/> that is the result of the subtraction operation.</returns>
        public static Point Subtract(Point pt, Size sz) => new Point(pt.X - sz.Width, pt.Y - sz.Height);

        /// <summary>
        /// Translates this <see cref="Point"/> by the specified amount.
        /// </summary>
        /// <param name="dx">The amount to offset the x-coordinate.</param>
        /// <param name="dy">The amount to offset the y-coordinate.</param>
        public void Offset(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        /// <summary>
        /// Translates this <see cref="Point"/> by the specified <see cref="Point"/>.
        /// </summary>
        /// <param name="pt">The <see cref="Point"/> used to offset this <see cref="Point"/>.</param>
        public void Offset(Point pt) => Offset(pt.X, pt.Y);

        /// <summary>
        /// Converts the specified <see cref="PointD"/> to a <see cref="Point"/> by rounding the values of the <see cref="PointD"/> to the next higher integer values.
        /// </summary>
        /// <param name="val">The <see cref="PointD"/> to convert.</param>
        /// <returns>The <see cref="Point"/> this method converts to.</returns>
        public static Point Ceiling(PointD val) => new Point((int)Math.Ceiling(val.X), (int)Math.Ceiling(val.Y));

        /// <summary>
        /// Converts the specified <see cref="PointD"/> to a <see cref="Point"/> by rounding the values of the <see cref="PointD"/> to the nearest integer.
        /// </summary>
        /// <param name="val">The <see cref="PointD"/> to convert.</param>
        /// <returns>The <see cref="Point"/> this method converts to.</returns>
        public static Point Round(PointD val) => new Point((int)Math.Round(val.X), (int)Math.Round(val.Y));

        /// <summary>
        /// Converts the specified <see cref="PointD"/> to a <see cref="Point"/> by truncating the values of the <see cref="PointD"/>.
        /// </summary>
        /// <param name="val">The <see cref="PointD"/> to convert.</param>
        /// <returns>The <see cref="Point"/> this converts to.</returns>
        public static Point Truncate(PointD val) => new Point((int)Math.Truncate(val.X), (int)Math.Truncate(val.Y));

        /// <inheritdoc />
        public bool Equals(Point point) => X == point.X && Y == point.Y;

        /// <inheritdoc />
        public override bool Equals(object obj) => !(obj is Point) ? false : Equals((Point)obj);

        /// <inheritdoc />
        public override int GetHashCode() => unchecked(this.GenerateHashCode(X, Y));

        /// <inheritdoc />
        public override string ToString() => $"[X: {X}, Y: {Y}]";

        /// <summary>
        /// Translates a <see cref="Point"/> by a given <see cref="Size"/>.
        /// </summary>
        /// <param name="pt">The <see cref="Point"/> to translate.</param>
        /// <param name="sz">A <see cref="Size"/> that specifies the pair of numbers to add to the coordinates of <paramref name="pt"/>.</param>
        /// <returns>A <see cref="Point"/> structure that is translated by a given <see cref="Size"/> structure.</returns>
        public static Point operator +(Point pt, Size sz) => Add(pt, sz);

        /// <summary>
        /// Translates a <see cref="Point"/> by the negative of a given <see cref="Size"/>.
        /// </summary>
        /// <param name="pt">The <see cref="Point"/> to translate.</param>
        /// <param name="sz">A <see cref="Size"/> that specifies the pair of numbers to subtract from the coordinates of <paramref name="pt"/>.</param>
        /// <returns>A <see cref="Point"/> structure that is translated by the negative of a given <see cref="Size"/> structure.</returns>
        public static Point operator -(Point pt, Size sz) => Subtract(pt, sz);

        /// <summary>
        /// Tests whether two specified <see cref="Point"/> structures are equivalent.
        /// </summary>
        /// <param name="left">The <see cref="Point"/> that is to the left of the equality operator.</param>
        /// <param name="right">The <see cref="Point"/> that is to the right of the equality operator.</param>
        /// <returns><see langword="true"/> if the two <see cref="Point"/> structures are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Point left, Point right) => left.Equals(right);

        /// <summary>
        /// Tests whether two specified <see cref="Point"/> structures are different.
        /// </summary>
        /// <param name="left">The <see cref="Point"/> that is to the left of the inequality operator.</param>
        /// <param name="right">The <see cref="Point"/> that is to the right of the inequality operator.</param>
        /// <returns><see langword="true"/> if the two <see cref="Point"/> structures are different; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Point left, Point right) => !(left == right);

        /// <summary>
        /// Converts the specified <see cref="Point"/> structure to a <see cref="Size"/> structure.
        /// </summary>
        /// <param name="pt">The <see cref="Point"/> to be converted.</param>
        /// <returns>The <see cref="Size"/> that results from the conversion.</returns>
        public static explicit operator Size(Point pt) => new Size(pt);

        /// <summary>
        /// Converts the specified <see cref="Point"/> structure to a <see cref="PointD"/> structure.
        /// </summary>
        /// <param name="pt">The <see cref="Point"/> to be converted.</param>
        /// <returns>The <see cref="PointD"/> that results from the conversion.</returns>
        public static explicit operator PointD(Point pt) => new PointD(pt.X, pt.Y);
    }
}