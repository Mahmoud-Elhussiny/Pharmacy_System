using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class GetRepresenterByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetRepresenterById/";
        public int Id { get; set; }

    }
}
