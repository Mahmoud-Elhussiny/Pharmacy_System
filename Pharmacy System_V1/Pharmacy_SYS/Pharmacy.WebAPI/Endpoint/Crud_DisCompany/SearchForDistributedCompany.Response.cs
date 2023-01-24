using Pharmacy.Application.Business.Crud_DisCompany.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class SearchForDistributedCompanyEndPointResponse : BaseRessponse
    {
        public SearchForDistributedCompanyEndPointResponse() { }
        public SearchForDistributedCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<All_DistributedCompanies> distributedCompanies { get; set; }

    }
}
