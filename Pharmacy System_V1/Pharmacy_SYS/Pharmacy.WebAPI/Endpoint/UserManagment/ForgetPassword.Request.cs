using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class ForgetPasswordEndPointRequest : BaseRequest
    {
        public const string Route = "/api/ForgetPassword/";
        public string email { get; set; }
        public string userName { get; set; }
    }
}
