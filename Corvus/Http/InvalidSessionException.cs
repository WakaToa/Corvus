using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus.Http
{
    public class InvalidSessionException : Exception
    {
        public InvalidSessionException() : base("SessionId is invalid!")
        {

        }
    }
}
