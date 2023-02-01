using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class DeletePurchasingBillHandlerOutput : BaseResponse
    {
        public DeletePurchasingBillHandlerOutput() { }
        public DeletePurchasingBillHandlerOutput(Guid correlationId) : base(correlationId) { }
      public string? Message { get; set; }

    }
}
