using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;
namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class GetAll_UserEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetAll_User/";
    }
}
