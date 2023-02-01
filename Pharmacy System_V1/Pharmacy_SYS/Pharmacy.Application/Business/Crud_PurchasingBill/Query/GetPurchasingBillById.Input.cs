using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Query
{
    public class GetPurchasingBillByIdHandlerInput : BaseRequest, IRequest<GetPurchasingBillByIdHandlerOutput>
    {
        public GetPurchasingBillByIdHandlerInput() { }
        public GetPurchasingBillByIdHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
