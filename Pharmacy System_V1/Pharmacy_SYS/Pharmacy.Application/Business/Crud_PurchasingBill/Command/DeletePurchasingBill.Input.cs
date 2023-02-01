using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class DeletePurchasingBillHandlerInput : BaseRequest, IRequest<DeletePurchasingBillHandlerOutput>
    {
        public DeletePurchasingBillHandlerInput() { }
        public DeletePurchasingBillHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
