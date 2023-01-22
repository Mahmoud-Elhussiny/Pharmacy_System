using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class CreateTheManufacturerEndPointRequest : BaseRequest
    {
        public const string Route = "/api/CreateTheManufacturer/";
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public string Location { get; set; }
        public string Phone { get; set; }
    }
}
