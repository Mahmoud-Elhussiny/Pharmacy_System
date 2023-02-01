using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class UpdateTheManufacturerEndPointResponse : BaseResponse
    {
        public UpdateTheManufacturerEndPointResponse() { }
        public UpdateTheManufacturerEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
