using System;
using ShapeMaster.Domain.Common;

namespace ShapeMaster.Domain.Entities
{
    internal class Rectangle : Shape
    {
        public decimal ASide { get; set; }
        public decimal BSide { get; set; }

        public Rectangle()
        {
            Type = "Rectangle";
        }

        public override decimal GetArea()
        {
            return ASide * BSide;
        }
    }
}
