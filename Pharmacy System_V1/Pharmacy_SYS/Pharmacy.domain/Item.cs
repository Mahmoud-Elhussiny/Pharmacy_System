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
        public DateTime expireDate { get; set; }
        public int Quantity { get; set; }
        public int? Num_Trade_Bar { get; set; }
        public int? Quantity_Trade_Bar { get; set; }
        public decimal? buyingPrice { get; set; }
        public decimal? sellingPrice { get; set; }
        public DateTime timeCreated { get; set; }
        public DateTime timeModified { get; set; }
        [ForeignKey("Category")]
        public int? categoryId { get; set; }
        [ForeignKey("Stock")]
        public int stockId { get; set; }
        [ForeignKey("TheManufacturer")]
        public int manufactureId { get; set; }
        [ForeignKey("DistributedCompany")]
        public int distributedId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual TheManufacturer TheManufacturer { get; set; }
        public virtual DistributedCompany DistributedCompany { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }



    }
}
