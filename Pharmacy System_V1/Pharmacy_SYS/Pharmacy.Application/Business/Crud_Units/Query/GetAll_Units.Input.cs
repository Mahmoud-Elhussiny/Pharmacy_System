using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class GetAll_UnitsHandlerInput : BaseRequest, IRequest<GetAll_UnitsHandlerOutput>
    {
        public GetAll_UnitsHandlerInput() { }
        public GetAll_UnitsHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
