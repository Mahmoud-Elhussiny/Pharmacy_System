using Pharmacy.Application.Business.Crud_Manufacturer.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class GetAllManufacturersEndPointResponse : BaseResponse
    {
        public GetAllManufacturersEndPointResponse() { }
        public GetAllManufacturersEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<All_Manufacturers> all_Manufacturers { get; set; }

    }
}
