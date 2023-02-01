using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Query
{
    public class SearchForPurchasingBillHandlerInput : BaseRequest, IRequest<SearchForPurchasingBillHandlerOutput>
    {
        public SearchForPurchasingBillHandlerInput() { }
        public SearchForPurchasingBillHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
