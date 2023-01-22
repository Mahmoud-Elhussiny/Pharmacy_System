using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class SearchForDistributedCompanyEndPointRequest : BaseRequest
    {
        public const string Route = "/api/SearchForDistributedCompany/";
        public int? Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public int? TheManufacturerId { get; set; }
    }
}
