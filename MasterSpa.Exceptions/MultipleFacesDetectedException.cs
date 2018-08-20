using System;
using System.Collections.Generic;
using System.Text;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 462
    /// </summary>
    public class MultipleFacesDetectedException : MasterSpaException
    {
        public override int StatusCode => 462;
    }
}
