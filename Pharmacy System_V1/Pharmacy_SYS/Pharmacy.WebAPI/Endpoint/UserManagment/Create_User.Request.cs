using Microsoft.AspNetCore.Mvc;
using Phone_Book.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class Create_UserEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Create_User/";


        public string? firstName { get; set; } = null!;
        public string? lastName { get; set; } = null!;
        public string? Phone1 { get; set; } = "";
        public string? Phone2 { get; set; } = "";
        public string? Address { get; set; } = "";
        public string UserName { get; set; } = "";

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int? isAdmin { get; set; }
        public string Email { get; set; } = null!;
    }
}
