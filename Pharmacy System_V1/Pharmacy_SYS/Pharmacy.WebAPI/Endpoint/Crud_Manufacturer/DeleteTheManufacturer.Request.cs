using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class DeleteTheManufacturerEndPointRequest : BaseRequest
    {
        public const string Route = "/api/DeleteTheManufacturer/";
        public int Id { get; set; }
    }
}
