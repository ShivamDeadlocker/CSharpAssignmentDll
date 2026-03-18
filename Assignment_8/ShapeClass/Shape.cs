using System;

namespace ShapeClass
{
    /// <summary>
    /// Abstract base class representing a generic shape.
    /// Each derived shape must implement its own area calculation.
    /// </summary>
    public abstract class Shape
    {
        // Name of the shape
        public string ShapeName { get; }

        // Stores the calculated area
        public double CalculatedArea { get; set; }

        /// <summary>
        /// Constructor used to initialize shape name.
        /// </summary>
        public Shape(string shapeName)
        {
            ShapeName = shapeName;
        }

        /// <summary>
        /// Abstract method to calculate area of a shape.
        /// Must be implemented by derived classes.
        /// </summary>
        public abstract void CalculateArea();
    }
}