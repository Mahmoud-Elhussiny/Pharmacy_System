using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class GetCalenderByIdHandlerInput : BaseRequest, IRequest<GetCalenderByIdHandlerOutput>
    {
        public GetCalenderByIdHandlerInput() { }
        public GetCalenderByIdHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
    }
}
