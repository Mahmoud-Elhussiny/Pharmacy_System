using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class UpdateTheManufacturerEndPointResponse : BaseRessponse
    {
        public UpdateTheManufacturerEndPointResponse() { }
        public UpdateTheManufacturerEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
