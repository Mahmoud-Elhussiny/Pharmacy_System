using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    [Table("OrderItem")]
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Order")]
        public int orderId { get; set; }
        [ForeignKey("Item")]
        public int itemId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Item Item { get; set; }

    }
}
