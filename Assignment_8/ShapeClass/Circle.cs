using System;

namespace ShapeClass
{
    /// <summary>
    /// Represents a circle shape and calculates its area.
    /// </summary>
    public class Circle : Shape
    {
        // Radius of the circle
        public double Radius { get; set; }

        public Circle(string sname, double radius) : base(sname)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Calculates area of the circle.
        /// Formula: 3.14 * radius * radius
        /// </summary>
        public override void CalculateArea()
        {
            CalculatedArea = Math.PI * Radius * Radius;
        }
    }
}