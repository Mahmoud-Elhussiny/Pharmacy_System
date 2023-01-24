using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Update_ItemTypeEndPointResponse : BaseRessponse
    {
        public Update_ItemTypeEndPointResponse() { }
        public Update_ItemTypeEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
