using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Query
{
    public class GetAllRepresentersHandlerInput : BaseRequest, IRequest<GetAllRepresentersHandlerOutput>
    {
        public GetAllRepresentersHandlerInput() { }
        public GetAllRepresentersHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
