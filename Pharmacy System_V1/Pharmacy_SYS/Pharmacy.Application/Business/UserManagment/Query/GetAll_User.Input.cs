using MediatR;
using Phone_Book.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Query
{
    public class GetAll_UserHandlerInput : BaseRequest, IRequest<GetAll_UserHandlerOutput>
    {
        public GetAll_UserHandlerInput() { }
        public GetAll_UserHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
