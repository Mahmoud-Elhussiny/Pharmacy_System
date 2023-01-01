using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    [Table("OrderType")]
    public class OrderType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual Order Order { get; set; }
    }
}
