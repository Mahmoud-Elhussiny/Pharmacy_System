using Pharmacy.Application.Masseges;
namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class GetUserByUserNameEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetUserByUserName/";
        public string userName { get; set; }

    }
}
