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
        public DbSet<Stock> Stock { get; set; }
        public DbSet<TheManufacturer> TheManufacturer { get; set; }
        public DbSet<DistributedCompany> distributedCompanies { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderType> orderTypes { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Invoice> invoices { get; set; }
    }
}
