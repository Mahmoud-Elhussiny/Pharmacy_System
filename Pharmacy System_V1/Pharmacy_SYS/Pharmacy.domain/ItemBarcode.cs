using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class ItemBarcode
    {
        public int Id { get; set; }
        [ForeignKey("Item")]
        public int itemId { get; set; }
        public DateTime productionDate { get; set; }
        public string codeGenerated { get; set; }
        public virtual Item Item { get; set; }
        public virtual ICollection<DataWarehouse>? DataWarehouses { get; set; }

    }
}
