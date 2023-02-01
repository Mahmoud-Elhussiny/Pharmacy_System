using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Delete_CalenderEndPointResponse : BaseResponse
    {
        public Delete_CalenderEndPointResponse() { }
        public Delete_CalenderEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
