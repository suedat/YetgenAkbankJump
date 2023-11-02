using System;
using ShapeMaster.Domain.Abstract;

namespace ShapeMaster.Domain.Common

{
    public abstract class Shape : EntityBase<Guid>, ISaveableShape
    {
        public string Type { get; set; }
        public abstract decimal GetArea();

        public string GetInfo()
        {
            return $"{Type} AREA: {GetArea()}";
        }
    }
}