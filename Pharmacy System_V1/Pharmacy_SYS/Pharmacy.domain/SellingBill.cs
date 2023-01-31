using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class SellingBill
    {
        public int Id { get; set; }
        public decimal totalPrice { get; set; }
        public int discount { get; set; }
        public int tax { get; set; }
        public DateTime timeCreated { get; set; }
        [ForeignKey("ApplicationUser")]
        public string userId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<SellingBillDetails> SellingBillDetails { get; set; }

        
    }
}
