using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class DeleteTheManufacturerEndPointResponse : BaseRessponse
    {
        public DeleteTheManufacturerEndPointResponse() { }
        public DeleteTheManufacturerEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
