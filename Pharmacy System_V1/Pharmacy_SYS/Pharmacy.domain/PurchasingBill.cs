using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class PurchasingBill
    {
        public int Id { get; set; }
        public decimal totalPrice { get; set; }
        public int discount { get; set; }
        public int tax { get; set; }
        public DateTime timeCreated { get; set; }
        [ForeignKey("ApplicationUser")]
        public string userId { get; set; }
        
        [ForeignKey("Representer")]
        public int? representerId { get; set; }
        public virtual Representer? Representer { get; set; }
        
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<PuchasingBillDetails> PuchasingBillDetails { get; set; }
        

    }
}
