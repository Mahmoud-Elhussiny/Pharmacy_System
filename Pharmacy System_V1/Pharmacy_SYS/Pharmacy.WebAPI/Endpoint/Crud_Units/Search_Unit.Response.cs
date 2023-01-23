
using Pharmacy.Application.Business.Crud_Units.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Search_UnitEndPointResponse : BaseResponse
    {
        public Search_UnitEndPointResponse() { }
        public Search_UnitEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<SearchlistofUnit> searchlistofUnits { get; set; }
    }
}
