using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 456
    /// </summary>
    public class InvalidTokenException : MasterSpaException
    {
        public InvalidTokenException() { }

        public override int StatusCode => 456;
    }
}
