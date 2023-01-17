using Pharmacy.Application.Masseges;
namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class SearchForUserEndPointRequest : BaseRequest
    {
        public const string Route = "/api/SearchForUser/";
        public string? firstName { get; set; }
        //public string? lastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public int? isAdmin { get; set; }
    }
}
