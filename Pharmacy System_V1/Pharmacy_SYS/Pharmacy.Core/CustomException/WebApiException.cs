using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core.CustomException
{
    public class WebApiException: Exception
    {
        public WebApiExceptionSource ExceptionSource { get; }

        public WebApiException()
            : this("Internal Server Error")
        {
            ExceptionSource = WebApiExceptionSource.GeneralException;
        }

        public WebApiException(string message, params object[] args)
            : this(WebApiExceptionSource.FromTranslation, message, args)
        {
            ExceptionSource = WebApiExceptionSource.FromTranslation;
        }

        public WebApiException(WebApiExceptionSource webApiExceptionSource, string message, params object[] args)
            : this(null, webApiExceptionSource, message, args)
        {
            ExceptionSource = webApiExceptionSource;
        }

        public WebApiException(Exception? innerException, WebApiExceptionSource webApiExceptionSource, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            ExceptionSource = webApiExceptionSource;
        }

        public override string ToString()
        {
            ExceptionOutput value = new ExceptionOutput
            {
                ErrorMessageType = ExceptionSource,
                Message = Message,
                Details = (base.InnerException?.Message ?? ""),
                ExtraDetails = (base.InnerException?.InnerException?.Message ?? "")
            };
            return JsonConvert.SerializeObject(value);
        }
    }
}
