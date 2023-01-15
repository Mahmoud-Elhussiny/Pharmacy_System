using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class ItemType
    {
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
    }
}
