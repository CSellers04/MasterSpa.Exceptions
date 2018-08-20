using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 457
    /// </summary>
    public class NotAuthorizedException : MasterSpaException
    {
        public NotAuthorizedException() { }

        public override int StatusCode => 457;
    }
}
