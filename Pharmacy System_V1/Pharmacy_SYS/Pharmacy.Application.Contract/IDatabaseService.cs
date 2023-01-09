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
        public DbSet<Unit> units { get; set; }
        public DbSet<ApplicationUser> AppUser { get; set; }
        public DbSet<Representer> representers { get; set; }
        public DbSet<TheManufacturer> TheManufacturer { get; set; }
        public DbSet<DistributedCompany> distributedCompanies { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<ItemType> itemTypes { get; set; }
        public DbSet<ItemUnit> itemUnits { get; set; }
        public DbSet<SellingBill> sellingBills { get; set; }
        public DbSet<SellingBillDetails> sellingBillDetails { get; set; }
        public DbSet<PurchasingBill> purchasingBills { get; set; }
        public DbSet<PuchasingBillDetails> puchasingBillDetails { get; set; }
        public DbSet<ItemBarcode> itemBarcodes { get; set; }
        public DbSet<DataWarehouse> dataWarehouses { get; set; }
    }
}
