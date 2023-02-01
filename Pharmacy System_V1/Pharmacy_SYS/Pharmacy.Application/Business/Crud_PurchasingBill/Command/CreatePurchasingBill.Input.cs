using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class CreatePurchasingBillHandlerInput : BaseRequest, IRequest<CreatePurchasingBillHandlerOutput>
    {
        public CreatePurchasingBillHandlerInput() { }
        public CreatePurchasingBillHandlerInput(Guid correlationId) : base(correlationId) { }
        public decimal totalPrice { get; set; }
        public int discount { get; set; }
        public int tax { get; set; }
        //public DateTime timeCreated { get; set; }
        public string userId { get; set; }
        public int? representerId { get; set; }
        public List<Purchasing_Details> purchasing_Details { get; set; }
    }
    public class Purchasing_Details
    {
        public int quantity { get; set; }
        public int? itemId { get; set; }
        public int? unitId { get; set; }
        public int purchasingbillId { get; set; }
    }
}
