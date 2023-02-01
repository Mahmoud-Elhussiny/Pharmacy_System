using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_SellingBill.Command
{
    public class CreateSellingBillHandlerOutput : BaseResponse
    {
        public CreateSellingBillHandlerOutput() { }
        public CreateSellingBillHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
