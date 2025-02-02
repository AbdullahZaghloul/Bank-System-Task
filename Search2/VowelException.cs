using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search2
{
    internal class VowelException : Exception
    {
        public VowelException(string message) : base(message) { }
    }
}
