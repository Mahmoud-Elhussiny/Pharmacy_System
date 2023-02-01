using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Query
{
    public class GetAllPurchasingBillHandlerInput : BaseRequest, IRequest<GetAllPurchasingBillHandlerOutput>
    {
        public GetAllPurchasingBillHandlerInput() { }
        public GetAllPurchasingBillHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
