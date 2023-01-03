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
        [MaxLength(11)]
        [MinLength(11)]
        public string? Phone2 { get; set; } = "";
        [MaxLength(100)]
        [MinLength(5)]
        public string? Address { get; set; } = "";

        public bool isActive { get; set; }
        public string? Picture { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Order> Orders { get; set; }


    }
}
