using System;

namespace ShapeClass
{
    /// <summary>
    /// Represents a triangle shape and calculates its area.
    /// </summary>
    public class Triangle : Shape
    {
        // Base length of triangle
        public double BaseLength { get; set; }

        // Height of triangle
        public double Height { get; set; }

        public Triangle(string sname, double baseLength, double height) : base(sname)
        {
            this.BaseLength = baseLength;
            this.Height = height;
        }

        /// <summary>
        /// Calculates area of triangle.
        /// Formula: 0.5 × Base × Height
        /// </summary>
        public override void CalculateArea()
        {
            CalculatedArea = 0.5 * (BaseLength * Height);
        }
    }
}