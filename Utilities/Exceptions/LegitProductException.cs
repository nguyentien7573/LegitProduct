using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Exceptions
{
    public class LegitProductException : Exception
    {
        public LegitProductException()
        {
        }

        public LegitProductException(string message)
            : base(message)
        {
        }

        public LegitProductException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
