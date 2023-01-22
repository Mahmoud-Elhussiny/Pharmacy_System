using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Items.Query
{
    public class GetItemByIdHandlerInput : BaseRequest, IRequest<GetItemByIdHandlerOutput>
    {
        public GetItemByIdHandlerInput() { }
        public GetItemByIdHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
