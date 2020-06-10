/***********************************************************************************************************************
 * FileName:            Rectangle.cs
 * Copyright/License:   https://github.com/tacdevel/tacdevlibs/blob/master/LICENSE.md
***********************************************************************************************************************/

using System;
using System.Runtime.InteropServices;

namespace TACDevel.Drawing
{
    /// <summary>
    /// Stores a set of four integers that represent the location and size of a rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Rectangle : IEquatable<Rectangle>
    {
        /// <summary>
        /// Represents a <see cref="Rectangle"/> that has it's values set to zero.
        /// </summary>
        public static readonly Rectangle Empty = new Rectangle();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class with the specified location and size.
        /// </summary>
        /// <param name="x">The x-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="y">The y-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class with the specified location and size.
        /// </summary>
        /// <param name="location">A <see cref="Point"/> that represents the upper-left corner of the rectangle.</param>
        /// <param name="size">A <see cref="Drawing.Size"/> that represents the width and height of the rectangle.</param>
        public Rectangle(Point location, Size size) : this(location.X, location.Y, size.Width, size.Height) { }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Rectangle"/> is empty.
        /// </summary>
        public bool IsEmpty => this == Empty;

        /// <summary>
        /// Gets or sets the coordinates of the upper-left corner of this <see cref="Rectangle"/>.
        /// </summary>
        public Point Location
        {
            get => new Point(X, Y);
            set
            {
                if (X != value.X)
                    X = value.X;
                if (Y != value.Y)
                    Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets the size of this <see cref="Rectangle"/>.
        /// </summary>
        public Size Size
        {
            get => new Size(Width, Height);
            set
            {
                if (Width != value.Width)
                    Width = value.Width;
                if (Height != value.Height)
                    Height = value.Height;
            }
        }

        /// <summary>
        /// Gets or sets the x-coordinate of the upper-left corner of this <see cref="Rectangle"/>.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of the upper-left corner of this <see cref="Rectangle"/>.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the width of this <see cref="Rectangle"/>.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of this <see cref="Rectangle"/>.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets the x-coordinate of the upper-left corner of this <see cref="Rectangle"/>.
        /// </summary>
        public int Left => X;

        /// <summary>
        /// Gets the y-coordinate of the upper-left corner of this <see cref="Rectangle"/>.
        /// </summary>
        public int Top => Y;

        /// <summary>
        /// Gets the x-coordinate of the lower-right corner of this <see cref="Rectangle"/>.
        /// </summary>
        public int Right => unchecked(X + Width);

        /// <summary>
        /// Gets the y-coordinate of the lower-right corner of this <see cref="Rectangle"/>.
        /// </summary>
        public int Bottom => unchecked(Y + Height);

        /// <summary>Converts the specified <see cref="RectangleD"/> structure to a <see cref="Rectangle"/> structure by rounding the <see cref="RectangleD"/> values to the next higher integer values.
        /// </summary>
        /// <param name="val">The <see cref="RectangleD"/> to convert.</param>
        /// <returns>The <see cref="Rectangle"/> this method converts to.</returns>
        public static Rectangle Ceiling(RectangleD val) => unchecked(new Rectangle((int)Math.Ceiling(val.X), (int)Math.Ceiling(val.Y), (int)Math.Ceiling(val.Width), (int)Math.Ceiling(val.Height)));

        /// <summary>
        /// Converts a <see cref="RectangleD"/> to a <see cref="Rectangle"/> by performing a truncate operation on all the coordinates.
        /// </summary>
        /// <param name="val">The <see cref="RectangleD"/> to convert.</param>
        /// <returns>The <see cref="Rectangle"/> this method converts to.</returns>
        public static Rectangle Truncate(RectangleD val) => unchecked(new Rectangle((int)val.X, (int)val.Y, (int)val.Width, (int)val.Height));

        /// <summary>
        /// Converts a <see cref="RectangleD"/> to a <see cref="Rectangle"/> by performing a round operation on all the coordinates.
        /// </summary>
        /// <param name="val">The <see cref="RectangleD"/> to convert.</param>
        /// <returns>The <see cref="Rectangle"/> this method converts to.</returns>
        public static Rectangle Round(RectangleD val) => unchecked(new Rectangle((int)Math.Round(val.X), (int)Math.Round(val.Y), (int)Math.Round(val.Width), (int)Math.Round(val.Height)));

        /// <summary>
        /// Determines if the specified point is contained within this <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="x">The x-coordinate of the <see cref="Point"/> to test.</param>
        /// <param name="y">The y-coordinate of the <see cref="Point"/> to test.</param>
        /// <returns><see langword="true"/> if the specified <see cref="Rectangle"/> is contained within this <see cref="Rectangle"/> structure; otherwise <see langword="false"/>.</returns>
        public bool Contains(int x, int y) => X <= x && x < X + Width && Y <= y && y < Y + Height;

        /// <summary>
        /// Determines if the specified point is contained within this <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="pt">A <see cref="Point"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="pt"/> is contained inside this <see cref="Rectangle"/>; else <see langword="false"/>.</returns>
        public bool Contains(Point pt) => Contains(pt.X, pt.Y);

        /// <summary>
        /// Determines if the specified <see cref="Rectangle"/>is entirely contained within this <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rect">A <see cref="Rectangle"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="rect"/> is contained inside this <see cref="Rectangle"/>; else <see langword="false"/>.</returns>
        public bool Contains(Rectangle rect) => (X <= rect.X) && (rect.X + rect.Width <= X + Width) && (Y <= rect.Y) && (rect.Y + rect.Height <= Y + Height);

        /// <summary>
        /// Inflates this <see cref="Rectangle"/> by the specified amount.
        /// </summary>
        /// <param name="width">The amount to inflate this <see cref="Rectangle"/> object's width.</param>
        /// <param name="height">The amount to inflate this <see cref="Rectangle"/> object's height.</param>
        public void Inflate(int width, int height)
        {
            unchecked
            {
                X -= width;
                Y -= height;
                Width += 2 * width;
                Height += 2 * height;
            }
        }

        /// <summary>
        /// Inflates this <see cref="Rectangle"/> by the specified amount.
        /// </summary>
        /// <param name="size">The <see cref="Drawing.Size"/> to inflate this <see cref="Rectangle"/> by.</param>
        public void Inflate(Size size) => Inflate(size.Width, size.Height);

        /// <summary>
        /// Creates a <see cref="Rectangle"/> that is inflated by the specified amount.
        /// </summary>
        /// <param name="rect">The <see cref="Rectangle"/> to inflate.</param>
        /// <param name="width">The amount to inflate this <see cref="Rectangle"/> object's width.</param>
        /// <param name="height">The amount to inflate this <see cref="Rectangle"/> object's height.</param>
        /// <returns>The inflated <see cref="Rectangle"/>.</returns>
        public static Rectangle Inflate(Rectangle rect, int width, int height)
        {
            Rectangle r = rect;
            r.Inflate(width, height);
            return r;
        }

        /// <summary>
        /// Creates a <see cref="Rectangle"/> that represents the intersection between this <see cref="Rectangle"/> and <paramref name="rect"/>.
        /// </summary>
        /// <param name="rect">A <see cref="Rectangle"/>.</param>
        public Rectangle Intersect(Rectangle rect) => Intersect(rect, this);

        /// <summary>
        /// Creates a rectangle that represents the intersection between <paramref name="a"/> and <paramref name="b"/>. If there is no intersection, null is returned.
        /// </summary>
        /// <param name="a">The first <see cref="Rectangle"/>.</param>
        /// <param name="b">The second <see cref="Rectangle"/>.</param>
        /// <returns>The intersected <see cref="Rectangle"/>. if no intersection, returns <see cref="Empty"/>.</returns>
        public static Rectangle Intersect(Rectangle a, Rectangle b)
        {
            int x1 = Math.Max(a.X, b.X);
            int x2 = Math.Min(a.X + a.Width, b.X + b.Width);
            int y1 = Math.Max(a.Y, b.Y);
            int y2 = Math.Min(a.Y + a.Height, b.Y + b.Height);

            return x2 >= x1 && y2 >= y1 ? new Rectangle(x1, y1, x2 - x1, y2 - y1) : Empty;
        }

        /// <summary>
        /// Determines if this <see cref="Rectangle"/> intersects with <paramref name="rect"/>.
        /// </summary>
        /// <param name="rect">The <see cref="Rectangle"/> to test.</param>
        /// <returns><see langword="true"/> if this <see cref="Rectangle"/> intersects with <paramref name="rect"/>; else <see langword="false"/>.</returns>
        public bool IntersectsWith(Rectangle rect) =>
            (rect.X < X + Width) && (X < rect.X + rect.Width) &&
            (rect.Y < Y + Height) && (Y < rect.Y + rect.Height);

        /// <summary>
        /// Gets a <see cref="Rectangle"/> structure that contains the union of two <see cref="Rectangle"/> structures.
        /// </summary>
        /// <param name="a">A <see cref="Rectangle"/> to union.</param>
        /// <param name="b">A <see cref="Rectangle"/> to union.</param>
        /// <returns>A <see cref="Rectangle"/> structure that bounds the union of the two <see cref="Rectangle"/> structures.</returns>
        public static Rectangle Union(Rectangle a, Rectangle b)
        {
            int x1 = Math.Min(a.X, b.X);
            int x2 = Math.Max(a.X + a.Width, b.X + b.Width);
            int y1 = Math.Min(a.Y, b.Y);
            int y2 = Math.Max(a.Y + a.Height, b.Y + b.Height);

            return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        }

        /// <summary>
        /// Adjusts the location of this rectangle by the specified amount.
        /// </summary>
        /// <param name="pos">Amount to offset the location.</param>
        public void Offset(Point pos) => Offset(pos.X, pos.Y);

        /// <summary>
        /// Adjusts the location of this rectangle by the specified amount.
        /// </summary>
        /// <param name="x">The horizontal offset.</param>
        /// <param name="y">The vertical offset.</param>
        public void Offset(int x, int y)
        {
            unchecked
            {
                X += x;
                Y += y;
            }
        }

        /// <summary>
        /// Creates a <see cref="Rectangle"/> structure with the specified edge locations.
        /// </summary>
        /// <param name="left">The x-coordinate of the upper-left corner.</param>
        /// <param name="top">The y-coordinate of the upper-left corner.</param>
        /// <param name="right">The x-coordinate of the lower-right corner.</param>
        /// <param name="bottom">The y-coordinate of the lower-right corner.</param>
        /// <returns>A new <see cref="Rectangle"/>.</returns>
        public static Rectangle FromLTRB(int left, int top, int right, int bottom) => new Rectangle(left, top, unchecked(right - left), unchecked(bottom - top));

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The object to compare with the current object.</param>
        /// <returns><see langword="true"/> if the specified object is equal to the current object; otherwise, <see langword="false"/>.
        public bool Equals(Rectangle other) => X == other.X && Y == other.Y && Width == other.Width && Height == other.Height;

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><see langword="true"/> if the specified object is equal to the current object; otherwise, <see langword="false"/>.
        public override bool Equals(object obj) => !(obj is Rectangle) ? false : Equals((Rectangle)obj);

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode() => unchecked(HashCode.Combine(X, Y, Width, Height));

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() => $"[X: {X}, Y: {Y}, Width: {Width}, Height: {Height}]";

        /// <summary>
        /// Tests whether two specified <see cref="Rectangle"/> structures are equivalent.
        /// </summary>
        /// <param name="left">The <see cref="Rectangle"/> that is to the left of the equality operator.</param>
        /// <param name="right">The <see cref="Rectangle"/> that is to the right of the equality operator.</param>
        /// <returns><see langword="true"/> if the two <see cref="Rectangle"/> structures are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Rectangle left, Rectangle right) => left.Equals(right);

        /// <summary>
        /// Tests whether two specified <see cref="Rectangle"/> structures are different.
        /// </summary>
        /// <param name="left">The <see cref="Rectangle"/> that is to the left of the inequality operator.</param>
        /// <param name="right">The <see cref="Rectangle"/> that is to the right of the inequality operator.</param>
        /// <returns><see langword="true"/> if the two <see cref="Rectangle"/> structures are different; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Rectangle left, Rectangle right) => !(left == right);

        /// <summary>
        /// Converts the specified <see cref="Rectangle"/> structure to a <see cref="RectangleD"/> structure.
        /// </summary>
        /// <param name="rect">The <see cref="Rectangle"/> to be converted.</param>
        /// <returns>The <see cref="RectangleD"/> that results from the conversion.</returns>
        public static explicit operator RectangleD(Rectangle rect) => new RectangleD(rect.X, rect.Y, rect.Width, rect.Height);
    }
}