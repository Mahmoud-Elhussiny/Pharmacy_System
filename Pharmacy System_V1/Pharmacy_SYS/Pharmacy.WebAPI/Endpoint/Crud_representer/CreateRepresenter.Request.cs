using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class CreateRepresenterEndPointRequest : BaseRequest
    {
        public const string Route = "/api/CreateRepresenter/";
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public int distributed_Company_Id { get; set; }
        public string phone { get; set; }
    }
}
