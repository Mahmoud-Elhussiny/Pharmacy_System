using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        public DateTime timeCreated { get; set; }
        public DateTime timeModified { get; set; }
        [ForeignKey("ApplicationUser")]
        public string userId { get; set; }
        [ForeignKey("OrderType")]
        public int? orderType { get; set; }


        public virtual OrderType? OrderType { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public virtual Invoice Invoice { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }


    }
}
