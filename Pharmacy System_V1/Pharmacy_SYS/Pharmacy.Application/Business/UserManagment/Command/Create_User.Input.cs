using MediatR;
using Phone_Book.Application.Masseges;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class Create_UserHandlerInput : BaseRequest, IRequest<Create_UserHandlerOutput>
    {
        public Create_UserHandlerInput() { }
        public Create_UserHandlerInput(Guid correlationId) : base(correlationId) { }




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
