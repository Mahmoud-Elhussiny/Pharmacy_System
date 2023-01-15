using Microsoft.AspNetCore.Mvc;
using Phone_Book.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class LoginEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Login/";

        public string userName { get; set; }
        public string Password { get; set; }
    }
}
