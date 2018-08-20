using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 455
    /// </summary>
    public class BusinessRuleException : MasterSpaException
    {
        public BusinessRuleException() { }

        public BusinessRuleException(string message) : base(message) { }

        public override int StatusCode => 455;
    }
}
