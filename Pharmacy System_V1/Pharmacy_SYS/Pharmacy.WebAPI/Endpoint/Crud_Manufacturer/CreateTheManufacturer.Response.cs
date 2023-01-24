using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class CreateTheManufacturerEndPointResponse : BaseRessponse
    {
        public CreateTheManufacturerEndPointResponse() { }
        public CreateTheManufacturerEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
