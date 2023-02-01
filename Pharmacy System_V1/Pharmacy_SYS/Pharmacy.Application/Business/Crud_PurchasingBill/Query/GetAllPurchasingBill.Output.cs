using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Query
{
    public class GetAllPurchasingBillHandlerOutput : BaseResponse
    {
        public GetAllPurchasingBillHandlerOutput() { }
        public GetAllPurchasingBillHandlerOutput(Guid correlationId) : base(correlationId) { }
        public List<Pruchasing_Bill> pruchasing_Bills { get; set; }

    }
    public class Pruchasing_Bill
    {
        public int Id { get; set; } 
        public decimal totalPrice { get; set; }
        public int discount { get; set; }
        public int tax { get; set; }
        //public DateTime timeCreated { get; set; }
        public string userId { get; set; }
        public int? representerId { get; set; }
        public List<purchasingDetils> purchasing_Details { get; set; }

    }
    public class purchasingDetils
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public int? itemId { get; set; }
        public int? unitId { get; set; }
        public int purchasingbillId { get; set; }

    }
}
