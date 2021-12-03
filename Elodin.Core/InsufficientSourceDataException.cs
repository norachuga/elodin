using System;

namespace Elodin.Core
{
    public class InsufficientSourceDataException : Exception
    {
        public InsufficientSourceDataException(string msg) 
            : base(msg) 
        { }
    }
}
