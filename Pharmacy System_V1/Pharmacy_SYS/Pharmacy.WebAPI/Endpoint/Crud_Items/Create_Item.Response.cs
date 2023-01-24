
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Create_ItemEndPointResponse : BaseResponse
    {
        public Create_ItemEndPointResponse() { }
        public Create_ItemEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string Message { get; set; }
    }
}
