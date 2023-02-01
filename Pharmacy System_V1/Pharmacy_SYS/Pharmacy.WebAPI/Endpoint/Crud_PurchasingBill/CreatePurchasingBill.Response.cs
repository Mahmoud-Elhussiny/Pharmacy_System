using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_PurchasingBill
{
    public class CreatePurchasingBillEndPointResponse : BaseResponse
    {
        public CreatePurchasingBillEndPointResponse() { }
        public CreatePurchasingBillEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
