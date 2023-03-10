using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    [Table("TheManufacturer")]
    public class TheManufacturer
    {
        public int Id { get; set; }
        [Required]
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public string Location { get; set; } = null!;
       
        public string Phone { get; set; } = null!;

        public ICollection<DistributedCompany> distributedCompanies { get; set; } = null!;
        public virtual ICollection<Item> Items { get; set; }

    }
}
