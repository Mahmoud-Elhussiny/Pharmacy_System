using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class GetAll_CalendersHandlerInput : BaseRequest, IRequest<GetAll_CalendersHandlerOutput>
    {
        public GetAll_CalendersHandlerInput() { }
        public GetAll_CalendersHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
