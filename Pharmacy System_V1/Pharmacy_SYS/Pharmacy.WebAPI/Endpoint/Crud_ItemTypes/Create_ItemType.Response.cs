using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Create_ItemTypeEndPointResponse : BaseResponse
    {
        public Create_ItemTypeEndPointResponse() { }
        public Create_ItemTypeEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
