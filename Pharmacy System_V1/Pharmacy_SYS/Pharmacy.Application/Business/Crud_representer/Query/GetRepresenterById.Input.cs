using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Query
{
    public class GetRepresenterByIdHandlerInput : BaseRequest, IRequest<GetRepresenterByIdHandlerOutput>
    {
        public GetRepresenterByIdHandlerInput() { }
        public GetRepresenterByIdHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
