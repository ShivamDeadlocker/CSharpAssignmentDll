using System;

namespace ShapeClass
{
    /// <summary>
    /// Represents a rectangle shape and calculates its area.
    /// </summary>
    public class Rectangle : Shape
    {
        // Height of rectangle
        public double Height { get; set; }

        // Width of rectangle
        public double Width { get; set; }

        public Rectangle(string sname, double height, double width) : base(sname)
        {
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Calculates area of rectangle.
        /// Formula: Height * Width
        /// </summary>
        public override void CalculateArea()
        {
            CalculatedArea = Height * Width;
        }
    }
}