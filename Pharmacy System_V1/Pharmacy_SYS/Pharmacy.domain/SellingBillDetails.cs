using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class SellingBillDetails
    {
        public int Id { get; set; }
        [ForeignKey("SellingBill")]
        public int sellingbillId { get; set; }
        [ForeignKey("Item")]
        public int? itemId { get; set; }
        public int quantity { get; set; }
        [ForeignKey("Unit")]
        public int? unitId { get; set; }
        public virtual SellingBill SellingBill { get; set; }
        public virtual Item? Item { get; set; }
        public virtual Unit? Unit { get; set; }
    }
}
