using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class SearchForManufacturerEndPointRequest : BaseRequest
    {
        public const string Route = "/api/SearchForManufacturer/";
        public int? Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
    }
}
