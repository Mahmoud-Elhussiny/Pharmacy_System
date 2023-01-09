using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class Representer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("DistributedCompany")]
        public int distributed_Company_Id { get; set; }
        public string phone { get; set; }
        public virtual DistributedCompany DistributedCompany { get; set; }
        public ICollection<PurchasingBill> PurchasingBill { get; set; }
    }
}
