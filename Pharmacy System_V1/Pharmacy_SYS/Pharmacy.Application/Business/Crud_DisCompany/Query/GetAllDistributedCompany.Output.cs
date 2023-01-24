using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Query
{
    public class GetAllDistributedCompanyHandlerOutput : BaseRessponse
    {
        public GetAllDistributedCompanyHandlerOutput() { }
        public GetAllDistributedCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }
        public List<AllDistributedCompanies>allDistributedCompanies { get; set; }

    }
    public class AllDistributedCompanies{
        public int Id { get; set; }
        public string NameEn { get; set; } 
        public string NameAr { get; set; } 
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public int? TheManufacturerId { get; set; }

    }
}
