using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class GetItemTypeByIdHandlerInput : BaseRequest, IRequest<GetItemTypeByIdHandlerOutput>
    {
        public GetItemTypeByIdHandlerInput() { }
        public GetItemTypeByIdHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }

    }
}
