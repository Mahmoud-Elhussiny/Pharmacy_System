using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_SellingBill.Command
{
    public class CreateSellingBillHandlerInput : BaseRequest, IRequest<CreateSellingBillHandlerOutput>
    {
        public CreateSellingBillHandlerInput() { }
        public CreateSellingBillHandlerInput(Guid correlationId) : base(correlationId) { }
        public decimal totalPrice { get; set; }
        public int discount { get; set; }
        public int tax { get; set; }
        public string userId { get; set; }
        public List<Selling_Details> purchasing_Details { get; set; }
    }
    public class Selling_Details
    {
        public int sellingbillId { get; set; }
        public int? itemId { get; set; }
        public int quantity { get; set; }
        public int? unitId { get; set; }
    }
}
