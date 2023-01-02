using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    [Table("OrderItem")]
    public class OrderItem
    {
        [Column(Order =0)]
        public int orderId { get; set; }
        [Column(Order =1)]
        public int itemId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; }

    }
}
