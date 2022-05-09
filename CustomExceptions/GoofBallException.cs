using System;

namespace CustomExceptions
{
    public class GoofBallException : Exception
    {
        public GoofBallException()
        {

        }

        public GoofBallException(string message) : base(message)
        {

        }

        public GoofBallException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}