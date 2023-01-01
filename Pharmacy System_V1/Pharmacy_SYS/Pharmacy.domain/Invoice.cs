using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? totalPrice { get; set; }
        public DateTime timeCreadted { get; set; }
        public DateTime timeModified { get; set; }
        [ForeignKey("Order")]
        public int orderId { get; set; }
        public virtual Order Order { get; set; }    
    }
}
