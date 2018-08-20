using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSpa.Exceptions
{
    /// <summary>
    /// Status Code => 460
    /// </summary>
    public class ValidationException : MasterSpaException
    {
        private List<string> _validationIssues { get; set; } = new List<string>();

        public ValidationException(List<string> validationIssues)
        {
            _validationIssues = validationIssues;
        }

        public List<string> Issues
        {
            get { return _validationIssues; }
        }

        public string AsHtml
        {
            get
            {
                return string.Join("<br />", _validationIssues.Select(o => $"<span>{o}</span>"));
            }
        }

        public string AsText
        {
            get
            {
                return string.Join(", ", _validationIssues.Select(o => o));
            }
        }

        public override int StatusCode => 460;
    }
}
