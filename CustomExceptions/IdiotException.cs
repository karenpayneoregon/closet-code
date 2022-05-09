using System;

namespace CustomExceptions
{
    public class IdiotException : Exception
    {
        public IdiotException()
        {

        }

        public IdiotException(string message) : base(message)
        {

        }

        public IdiotException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}