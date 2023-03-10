using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
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

        int DBSaveChanges();
        Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default);

        IDbContextTransaction DbBeginTransaction(System.Data.IsolationLevel isolationLevel);

        public DbSet<Units> units { get; set; }
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
        public DbSet<Calenders> Calenders{ get; set; }
    }
}
