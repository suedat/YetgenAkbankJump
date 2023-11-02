using System;
namespace ShapeMaster.Domain.Common
{
    public interface IModifiedOn
    {
        public DateTimeOffset ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}