using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class GetTheManufacturerByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetTheManufacturerById/";
        public int Id { get; set; }
    }
}
