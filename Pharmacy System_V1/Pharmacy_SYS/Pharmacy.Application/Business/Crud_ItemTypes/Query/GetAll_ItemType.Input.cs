using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class GetAll_ItemTypeHandlerInput : BaseRequest, IRequest<GetAll_ItemTypeHandlerOutput>
    {
        public GetAll_ItemTypeHandlerInput() { }
        public GetAll_ItemTypeHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
