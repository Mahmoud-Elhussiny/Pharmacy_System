using Microsoft.EntityFrameworkCore;
using Pharmacy.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Application.Contract
{
    public interface IDatabaseService
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationUser> AppUser { get; set; }
    }
}
