using MediatR;
using Phone_Book.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class Create_UserHandlerInput : BaseRequest, IRequest<Create_UserHandlerOutput>
    {
        public Create_UserHandlerInput() { }
        public Create_UserHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
