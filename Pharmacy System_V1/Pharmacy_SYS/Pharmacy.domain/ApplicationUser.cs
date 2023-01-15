using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
   //[Table("ph_user")]
   //changes
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [MaxLength(25)]
        public string firstName { get; set; } = null!;

        [Required]
        [MaxLength(25)]
        public string lastName { get; set; } = null!;
        
        [MaxLength(11)]
        [MinLength(11)]
        public string? Phone1 { get; set; } = "";

        //[Required]
        //[MaxLength(30)]
        //[MinLength(6)]
        //public string UserName { get; set; } = "";

        [MaxLength(11)]
        [MinLength(11)]
        public string? Phone2 { get; set; } = "";
        
        [MaxLength(100)]
        [MinLength(5)]
        public string? Address { get; set; } = "";

        public int? isAdmin { get; set; }
        
        public DateTime? lastloginDate { get; set; }
        public DateTime? timeCreated { get; set; }
        public bool isActive { get; set; }
        public byte[]? Picture { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<SellingBill> SellingBills { get; set; }
        public virtual ICollection<PurchasingBill> PurchasingBills { get; set; }
        public virtual ICollection<DataWarehouse> DataWarehouses { get; set; }


    }
}
