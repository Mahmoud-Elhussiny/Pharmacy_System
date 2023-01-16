using Microsoft.AspNetCore.Mvc;
using Phone_Book.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class GetAll_UserEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetAll_User/";
    }
}
