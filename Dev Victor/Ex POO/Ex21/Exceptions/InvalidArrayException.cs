using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21.Exceptions
{
    internal class InvalidArrayException: Exception
    {
        public InvalidArrayException() { }

        public InvalidArrayException(string? message) : base(message)
        {
        }
    }
}
