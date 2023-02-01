using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class CreatePurchasingBillHandlerOutput : BaseRessponse
    {
        public CreatePurchasingBillHandlerOutput() { }
        public CreatePurchasingBillHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
