using System;
using ShapeMaster.Domain.Common;

namespace ShapeMaster.Domain.Entities
{
    internal class Triangle : Shape
    {
        public decimal Attitude { get; set; }
        public decimal Base { get; set; }

        public Triangle()
        {
            Type = "Triangle";
        }

        public override decimal GetArea()
        {
            return (Attitude * Base) / 2;
        }
    }
}