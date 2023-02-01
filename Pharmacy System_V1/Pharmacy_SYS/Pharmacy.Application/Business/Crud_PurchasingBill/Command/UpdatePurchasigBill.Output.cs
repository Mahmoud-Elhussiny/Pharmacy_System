using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class UpdatePurchasigBillHandlerOutput : BaseResponse
    {
        public UpdatePurchasigBillHandlerOutput() { }
        public UpdatePurchasigBillHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
