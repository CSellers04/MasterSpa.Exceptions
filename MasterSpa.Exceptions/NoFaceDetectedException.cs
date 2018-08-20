using System;
using System.Collections.Generic;
using System.Text;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 461
    /// </summary>
    public class NoFaceDetectedException : MasterSpaException
    {
        public override int StatusCode => 461;
    }
}
