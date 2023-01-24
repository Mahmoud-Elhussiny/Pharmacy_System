using Pharmacy.Application.Business.Crud_DisCompany.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class GetAllDistributedCompanyEndPointResponse : BaseRessponse
    {
        public GetAllDistributedCompanyEndPointResponse() { }
        public GetAllDistributedCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<AllDistributedCompanies> allDistributedCompanies { get; set; }

    }
}
