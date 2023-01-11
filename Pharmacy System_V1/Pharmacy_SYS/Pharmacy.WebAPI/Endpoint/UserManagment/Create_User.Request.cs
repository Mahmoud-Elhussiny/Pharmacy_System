using Microsoft.AspNetCore.Mvc;
using Phone_Book.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class Create_UserEndPointRequest : BaseRequest
    {
        public const string Route = "/api/v{version:apiVersion}/Create_User/";
    }
}
