using Pharmacy.Application.Business.Crud_Units.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class GetAll_UnitsEndPointResponse : BaseRessponse
    {
        public GetAll_UnitsEndPointResponse() { }
        public GetAll_UnitsEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<listofUnit> listofUnits { get; set; }
    }
}
