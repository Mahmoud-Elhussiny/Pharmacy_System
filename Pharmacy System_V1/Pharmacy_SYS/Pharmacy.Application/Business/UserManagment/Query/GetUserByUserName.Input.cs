using MediatR;
using Phone_Book.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Query
{
    public class GetUserByUserNameHandlerInput : BaseRequest, IRequest<GetUserByUserNameHandlerOutput>
    {
        public GetUserByUserNameHandlerInput() { }
        public GetUserByUserNameHandlerInput(Guid correlationId) : base(correlationId) { }
        public string userName { get; set; }

    }
}
