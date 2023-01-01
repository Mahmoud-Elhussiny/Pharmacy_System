using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    [Table("DistributedCompany")]
    public class DistributedCompany
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; } = null!;
        public string? Location { get; set; }
        public string? Phone { get; set; }
        [ForeignKey("TheManufacturer")]
        public int? TheManufacturerId { get; set; }
        public virtual TheManufacturer? TheManufacturer { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
    }
}
