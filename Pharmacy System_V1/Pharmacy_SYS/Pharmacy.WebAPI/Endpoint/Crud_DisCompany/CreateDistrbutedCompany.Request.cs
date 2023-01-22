using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class CreateDistrbutedCompanyEndPointRequest : BaseRequest
    {
        public const string Route = "/api/CreateDistrbutedCompany/";
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public int? TheManufacturerId { get; set; }
    }
}
