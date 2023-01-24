using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Delete_ItemTypeEndPointResponse : BaseRessponse
    {
        public Delete_ItemTypeEndPointResponse() { }
        public Delete_ItemTypeEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
