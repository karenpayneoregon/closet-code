using System;

namespace CustomExceptions
{
    public class StupidFlandersException : Exception
    {
        public StupidFlandersException()
        {

        }

        public StupidFlandersException(string message) : base(message)
        {

        }

        public StupidFlandersException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}