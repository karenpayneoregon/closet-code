using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CommonLibrary.Classes
{
    public class JsonHelpers
    {
        /// <summary>
        /// For those who forget how to serialize with indentation
        /// </summary>
        public JsonSerializerOptions Indented 
            => new() { WriteIndented = true, };
    }
}
