using Pharmacy.Application.Business.Crud_Manufacturer.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class SearchForManufacturerEndPointResponse : BaseResponse
    {
        public SearchForManufacturerEndPointResponse() { }
        public SearchForManufacturerEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<AllManufacturers> allManufacturers { get; set; }

    }
}
