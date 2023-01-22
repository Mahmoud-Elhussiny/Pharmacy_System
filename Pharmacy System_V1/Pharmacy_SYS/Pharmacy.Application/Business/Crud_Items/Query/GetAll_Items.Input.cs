using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Items.Query
{
    public class GetAll_ItemsHandlerInput : BaseRequest, IRequest<GetAll_ItemsHandlerOutput>
    {
        public GetAll_ItemsHandlerInput() { }
        public GetAll_ItemsHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
