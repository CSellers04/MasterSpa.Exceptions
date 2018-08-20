using System;
using System.Collections.Generic;
using System.Text;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 463
    /// </summary>
    public class NoMatchFoundException : MasterSpaException
    {
        public override int StatusCode => 463;
    }
}
