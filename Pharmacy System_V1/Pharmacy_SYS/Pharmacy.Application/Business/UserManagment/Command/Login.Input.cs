using MediatR;
using Pharmacy.Application.Masseges;
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
