using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSpa.Exceptions
{
    public abstract class MasterSpaException : Exception
    {
        public MasterSpaException() { }

        public MasterSpaException(string message) : base(message) { }

        public abstract int StatusCode { get; }
    }
}
