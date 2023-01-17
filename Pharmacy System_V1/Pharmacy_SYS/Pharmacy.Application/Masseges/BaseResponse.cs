using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Application.Masseges
{
    public abstract class BaseResponse:BaseMasseges
    {
        public BaseResponse() {  }
        public BaseResponse(Guid correlationId):base()
        {
            _correlationId = correlationId;
        }
    }
}
