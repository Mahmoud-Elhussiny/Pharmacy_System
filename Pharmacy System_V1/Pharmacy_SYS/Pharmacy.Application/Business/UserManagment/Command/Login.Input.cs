using MediatR;
using Phone_Book.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LoginHandlerInput : BaseRequest, IRequest<LoginHandlerOutput>
    {
        public LoginHandlerInput() { }
        public LoginHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
