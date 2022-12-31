using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class TheManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public ICollection<DistributedCompany> distributedCompanies { get; set; } = null!;

    }
}
