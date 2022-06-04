using System;

namespace GenericExtensionsForFormControls.Models
{
    public abstract class BaseModel
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Modified { get; set; }
        public override string ToString() => Name;
    }
}