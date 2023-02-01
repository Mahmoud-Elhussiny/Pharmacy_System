using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Query
{
    public class GetPurchasingBillByIdHandlerOutput : BaseResponse
    {
        public GetPurchasingBillByIdHandlerOutput() { }
        public GetPurchasingBillByIdHandlerOutput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public decimal totalPrice { get; set; }
        public int discount { get; set; }
        public int tax { get; set; }
        public string userId { get; set; }
        public int? representerId { get; set; }
        public List<PurDetails> purchasing_Details { get; set; }

    }

    public class PurDetails
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public int? itemId { get; set; }
        public int? unitId { get; set; }
        public int purchasingbillId { get; set; }
    }
}
