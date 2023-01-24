
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Delete_ItemEndPointResponse : BaseRessponse
    {
        public Delete_ItemEndPointResponse() { }
        public Delete_ItemEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
