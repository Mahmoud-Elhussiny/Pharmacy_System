using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LogoutHandlerInput : BaseRequest, IRequest<LogoutHandlerOutput>
    {
        public LogoutHandlerInput() { }
        public LogoutHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
