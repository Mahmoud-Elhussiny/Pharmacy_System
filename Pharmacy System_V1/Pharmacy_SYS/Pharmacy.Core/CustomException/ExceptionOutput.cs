using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core.CustomException
{
    public class ExceptionOutput
    {
        public WebApiExceptionSource ErrorMessageType { get; set; }

        public string? Message { get; set; }

        public string? Details { get; set; }

        public string? ExtraDetails { get; set; }
    }
}
