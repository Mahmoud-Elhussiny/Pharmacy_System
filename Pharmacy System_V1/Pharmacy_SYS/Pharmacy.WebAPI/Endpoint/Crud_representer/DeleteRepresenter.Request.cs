using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class DeleteRepresenterEndPointRequest : BaseRequest
    {
        public const string Route = "/api/DeleteRepresenter/";
        public int Id { get; set; }
    }
}
