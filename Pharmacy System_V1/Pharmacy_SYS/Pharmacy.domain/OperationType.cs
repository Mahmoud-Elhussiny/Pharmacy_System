using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    // this operation to select type of operation (sell - purchas - ...)
    public class OperationType
    {
        public int Id { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }

        public List<DataWarehouse> dataWarehouses { get; set; }
    }
}
