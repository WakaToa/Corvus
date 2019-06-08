using System;

namespace Corvus.Http
{
    public class InvalidSessionException : Exception
    {
        public InvalidSessionException() : base("SessionId is invalid!")
        {

        }
    }
}
