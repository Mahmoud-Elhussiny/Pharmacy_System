using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.domain
{
    public class ApplicationUser:IdentityUser
    {
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string Phone1 { get; set; } = "";
        public string Phone2 { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
