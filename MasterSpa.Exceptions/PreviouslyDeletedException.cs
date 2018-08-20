using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 458
    /// </summary>
    public class PreviouslyDeletedException : MasterSpaException
    {
        public PreviouslyDeletedException() { }

        public override int StatusCode => 458;
    }
}
