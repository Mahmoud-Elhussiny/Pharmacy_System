using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class ItemUnit
    {
        public int Id { get; set; }
        [ForeignKey("Item")]
        public int itemId { get; set; }
        [ForeignKey("Unit")]
        public int unitId { get; set; }
        public int quantityContent { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<DataWarehouse> DataWarehouses { get; set; }

        public virtual Item Item { get; set; }  

    }
}
