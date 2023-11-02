using System;
using ShapeMaster.Domain.Common;

namespace ShapeMaster.Domain.Entities
{
    public class Square : Shape
    {
        public decimal OneSide { get; set; }

        public Square(decimal oneSide)
        {
            Type = "Square";
            OneSide = oneSide;
        }

        public override decimal GetArea()
        {
            return OneSide * OneSide;
        }
    }
}
