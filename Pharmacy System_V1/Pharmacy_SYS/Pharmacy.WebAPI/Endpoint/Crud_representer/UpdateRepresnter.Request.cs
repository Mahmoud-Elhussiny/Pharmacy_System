using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class UpdateRepresnterEndPointRequest : BaseRequest
    {
        public const string Route = "/api/UpdateRepresnter/";
        public int Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public int? distributed_Company_Id { get; set; }
        public string? phone { get; set; }
    }
}
