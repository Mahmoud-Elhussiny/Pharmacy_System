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
        public int? itemId { get; set; }
        public decimal Price { get; set; }
        
        public int CurrentAmount { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("ItemUnit")]
        public int? itemunitId { get; set; }

        [ForeignKey("OperationType")]
        public int? operationTypeId { get; set; }
        public int referanceoperationId { get; set; }
        public bool visable { get; set; }


        [ForeignKey("Barcode")]
        public int itembarcodeId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string? userId { get; set; }
        public DateTime timeCreated { get; set; }
        public virtual Item? Item { get; set; }
        public virtual ItemUnit? ItemUnit { get; set; }  
        public virtual ItemBarcode? Barcode { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public virtual OperationType? OperationType { get; set; }
      




    }
}
