using Pharmacy.Application.Business.Crud_PurchasingBill.Command;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_PurchasingBill
{
    public class CreatePurchasingBillEndPointRequest : BaseRequest
    {
        public const string Route = "/api/CreatePurchasingBill/";
        public decimal totalPrice { get; set; }
        public int discount { get; set; }
        public int tax { get; set; }
        //public DateTime timeCreated { get; set; }
        public string userId { get; set; }
        public int? representerId { get; set; }
        public List<Purchasing_Details> purchasing_Details { get; set; }
    }
}
