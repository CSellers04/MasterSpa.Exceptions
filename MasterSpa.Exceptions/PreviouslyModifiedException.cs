using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 459
    /// </summary>
    public class PreviouslyModifiedException : MasterSpaException
    {
        public PreviouslyModifiedException() { }

        public override int StatusCode => 459;
    }
}
