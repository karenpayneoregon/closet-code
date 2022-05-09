using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class DumbAssException : Exception
    {
        public DumbAssException()
        {
            
        }

        public DumbAssException(string message) : base(message)
        {
            
        }

        public DumbAssException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
