using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class DistributedCompany
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public int TheManufacturerId { get; set; }
        public TheManufacturer TheManufacturer { get; set; }=null!;
    }
}
