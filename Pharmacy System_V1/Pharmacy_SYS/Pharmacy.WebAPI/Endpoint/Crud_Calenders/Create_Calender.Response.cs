
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Create_CalenderEndPointResponse : BaseResponse
    {
        public Create_CalenderEndPointResponse() { }
        public Create_CalenderEndPointResponse(Guid correlationId) : base(correlationId) { }


        public string Message { get; set; }
    }
}
