using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class UpdatePurchasigBillHandlerInput : BaseRequest, IRequest<UpdatePurchasigBillHandlerOutput>
    {
        public UpdatePurchasigBillHandlerInput() { }
        public UpdatePurchasigBillHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public decimal? totalPrice { get; set; }
        public int? discount { get; set; }
        public int? tax { get; set; }
        public string? userId { get; set; }
        public int? representerId { get; set; }
        public List<Purchasing_Detalis_Updates> purchasing_Details { get; set; }
    }
    public class Purchasing_Detalis_Updates
    {
        public int Id { get; set; }
        public int? quantity { get; set; }
        public int? itemId { get; set; }
        public int? unitId { get; set; }
        public int? purchasingbillId { get; set; }
    }
}
