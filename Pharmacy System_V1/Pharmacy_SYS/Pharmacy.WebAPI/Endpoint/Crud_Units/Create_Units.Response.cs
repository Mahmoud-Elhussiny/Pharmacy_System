using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Create_UnitsEndPointResponse : BaseRessponse
    {
        public Create_UnitsEndPointResponse() { }
        public Create_UnitsEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string message { get; set; }
    }
}
