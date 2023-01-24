using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Query
{
    public class SearchForDistributedCompanyHandlerOutput : BaseRessponse
    {
        public SearchForDistributedCompanyHandlerOutput() { }
        public SearchForDistributedCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }
        public List<All_DistributedCompanies> distributedCompanies { get; set; }

    }
    
    public class All_DistributedCompanies
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public int? TheManufacturerId { get; set; }

    }
}
