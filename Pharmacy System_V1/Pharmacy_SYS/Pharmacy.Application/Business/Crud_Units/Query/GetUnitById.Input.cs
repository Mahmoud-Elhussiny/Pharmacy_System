using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class GetUnitByIdHandlerInput : BaseRequest, IRequest<GetUnitByIdHandlerOutput>
    {
        public GetUnitByIdHandlerInput() { }
        public GetUnitByIdHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
    }
}
