using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    [Table("Item")]
    public class Item
    {
        public int Id { get; set; }
        public string tradeName { get; set; } = "";
        public string chemicalName { get; set; } = "";
        public string Code { get; set; } = null!;
        public DateTime duration { get; set; }
        public decimal? buyingPrice { get; set; }
        public decimal? sellingPrice { get; set; }
        [ForeignKey("ItemType")]
        public int itemtypeId { get; set; }
        public int manufactureId { get; set; }
        [ForeignKey("DistributedCompany")]
        public int distributedId { get; set; }
        public virtual ICollection<ItemUnit> ItemUnits { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual TheManufacturer TheManufacturer { get; set; }
        public virtual DistributedCompany DistributedCompany { get; set; }
        public virtual ICollection<ItemBarcode> ItemBarcodes { get; set; }
        public virtual ICollection<SellingBillDetails> SellingBillDetails { get; set; }
        public virtual ICollection<DataWarehouse> DataWarehouses { get; set; }




    }
}
