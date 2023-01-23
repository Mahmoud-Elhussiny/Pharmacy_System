
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Update_ItemEndPointResponse : BaseResponse
    {
        public Update_ItemEndPointResponse() { }
        public Update_ItemEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string Message { get; set; }
    }
}
