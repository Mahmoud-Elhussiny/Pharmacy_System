using MediatR;
using Phone_Book.Application.Masseges;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LoginHandlerInput : BaseRequest, IRequest<LoginHandlerOutput>
    {
        public LoginHandlerInput() { }
        public LoginHandlerInput(Guid correlationId) : base(correlationId) { }
        public string userName { get; set; }
        public string Password { get; set; }
    }
}
