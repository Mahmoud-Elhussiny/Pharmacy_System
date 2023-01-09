using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class DataWarehouse
    {
        public int Id { get; set; }
        [ForeignKey("Item")]
        public int itemId { get; set; }
        public decimal sellingPrice { get; set; }
        public decimal buyingPrice { get; set; }
        [ForeignKey("ItemUnit")]
        public int itemunitId { get; set; }
        [ForeignKey("Barcode")]
        public int itembarcodeId { get; set; }
        [ForeignKey("ApplicationUser")]
        public int userId { get; set; }
        public DateTime timeCreated { get; set; }
        public virtual Item Item { get; set; }
        public virtual ItemUnit ItemUnit { get; set; }  
        public virtual ItemBarcode Barcode { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
