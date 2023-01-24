
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Delete_UnitsEndPointResponse : BaseRessponse
    {
        public Delete_UnitsEndPointResponse() { }
        public Delete_UnitsEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string message { get; set; }
    }
}
