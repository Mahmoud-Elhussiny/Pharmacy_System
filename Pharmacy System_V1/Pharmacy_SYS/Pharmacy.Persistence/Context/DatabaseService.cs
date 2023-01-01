using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Application.Contract;
using Pharmacy.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Persistence.Context
{
    public class DatabaseService : IdentityDbContext<ApplicationUser>, IDatabaseService
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) 
            : base(options)
        {

        }

        public DbSet<Category> Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<ApplicationUser> AppUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
