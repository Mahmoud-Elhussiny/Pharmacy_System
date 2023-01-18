using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class PuchasingBillDetails
    {
        public int Id { get; set; }
        [ForeignKey("Item")]
        public int? itemId { get; set; }
        public int quantity { get; set; }
        [ForeignKey("Unit")]
        public int? unitId { get; set; }
        [ForeignKey("PurchasingBill")]
        public int purchasingbillId { get; set; }
        public virtual Item? Item { get; set; }
        public virtual Units? Unit { get; set; }
        public virtual PurchasingBill PurchasingBill { get; set; }
    }
}
