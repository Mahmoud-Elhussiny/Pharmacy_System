﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pharmacy.Persistence.Context;

#nullable disable

namespace Pharmacy.Persistence.Migrations
{
    [DbContext(typeof(DatabaseService))]
    [Migration("20230115094253_intialDB")]
    partial class intialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Pharmacy.domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Phone2")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('true')");

                    b.Property<int?>("isAdmin")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("lastloginDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("timeCreated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Pharmacy.domain.DataWarehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("buyingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("itemId")
                        .HasColumnType("int");

                    b.Property<int>("itembarcodeId")
                        .HasColumnType("int");

                    b.Property<int?>("itemunitId")
                        .HasColumnType("int");

                    b.Property<decimal>("sellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("timeCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.HasIndex("itembarcodeId");

                    b.HasIndex("itemunitId");

                    b.HasIndex("userId");

                    b.ToTable("dataWarehouses");
                });

            modelBuilder.Entity("Pharmacy.domain.DistributedCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TheManufacturerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TheManufacturerId");

                    b.ToTable("DistributedCompany");
                });

            modelBuilder.Entity("Pharmacy.domain.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TheManufacturerId")
                        .HasColumnType("int");

                    b.Property<decimal?>("buyingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("chemicalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("distributedId")
                        .HasColumnType("int");

                    b.Property<DateTime>("duration")
                        .HasColumnType("datetime2");

                    b.Property<string>("itemNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("itemtypeId")
                        .HasColumnType("int");

                    b.Property<int?>("manufactureId")
                        .HasColumnType("int");

                    b.Property<int?>("molality")
                        .HasColumnType("int");

                    b.Property<decimal?>("sellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("tradeNameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tradeNameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("TheManufacturerId");

                    b.HasIndex("distributedId");

                    b.HasIndex("itemtypeId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Pharmacy.domain.ItemBarcode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("codeGenerated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("productionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.ToTable("itemBarcodes");
                });

            modelBuilder.Entity("Pharmacy.domain.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("nameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("itemTypes");
                });

            modelBuilder.Entity("Pharmacy.domain.ItemUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.Property<int>("quantityContent")
                        .HasColumnType("int");

                    b.Property<int>("unitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.HasIndex("unitId");

                    b.ToTable("itemUnits");
                });

            modelBuilder.Entity("Pharmacy.domain.PuchasingBillDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("itemId")
                        .HasColumnType("int");

                    b.Property<int>("purchasingbillId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int?>("unitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.HasIndex("purchasingbillId");

                    b.HasIndex("unitId");

                    b.ToTable("puchasingBillDetails");
                });

            modelBuilder.Entity("Pharmacy.domain.PurchasingBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.Property<int?>("representerId")
                        .HasColumnType("int");

                    b.Property<int>("tax")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("totalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("representerId");

                    b.HasIndex("userId");

                    b.ToTable("purchasingBills");
                });

            modelBuilder.Entity("Pharmacy.domain.Representer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("distributed_Company_Id")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("distributed_Company_Id");

                    b.ToTable("representers");
                });

            modelBuilder.Entity("Pharmacy.domain.SellingBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.Property<int>("tax")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("totalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("sellingBills");
                });

            modelBuilder.Entity("Pharmacy.domain.SellingBillDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("itemId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("sellingbillId")
                        .HasColumnType("int");

                    b.Property<int?>("unitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.HasIndex("sellingbillId");

                    b.HasIndex("unitId");

                    b.ToTable("sellingBillDetails");
                });

            modelBuilder.Entity("Pharmacy.domain.TheManufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("TheManufacturer");
                });

            modelBuilder.Entity("Pharmacy.domain.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("nameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("units");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Pharmacy.domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Pharmacy.domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Pharmacy.domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pharmacy.domain.DataWarehouse", b =>
                {
                    b.HasOne("Pharmacy.domain.Item", "Item")
                        .WithMany("DataWarehouses")
                        .HasForeignKey("itemId");

                    b.HasOne("Pharmacy.domain.ItemBarcode", "Barcode")
                        .WithMany("DataWarehouses")
                        .HasForeignKey("itembarcodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.domain.ItemUnit", "ItemUnit")
                        .WithMany("DataWarehouses")
                        .HasForeignKey("itemunitId");

                    b.HasOne("Pharmacy.domain.ApplicationUser", "ApplicationUser")
                        .WithMany("DataWarehouses")
                        .HasForeignKey("userId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Barcode");

                    b.Navigation("Item");

                    b.Navigation("ItemUnit");
                });

            modelBuilder.Entity("Pharmacy.domain.DistributedCompany", b =>
                {
                    b.HasOne("Pharmacy.domain.TheManufacturer", "TheManufacturer")
                        .WithMany("distributedCompanies")
                        .HasForeignKey("TheManufacturerId");

                    b.Navigation("TheManufacturer");
                });

            modelBuilder.Entity("Pharmacy.domain.Item", b =>
                {
                    b.HasOne("Pharmacy.domain.ApplicationUser", null)
                        .WithMany("Items")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Pharmacy.domain.TheManufacturer", "TheManufacturer")
                        .WithMany("Items")
                        .HasForeignKey("TheManufacturerId");

                    b.HasOne("Pharmacy.domain.DistributedCompany", "DistributedCompany")
                        .WithMany("Items")
                        .HasForeignKey("distributedId");

                    b.HasOne("Pharmacy.domain.ItemType", "ItemType")
                        .WithMany("Items")
                        .HasForeignKey("itemtypeId");

                    b.Navigation("DistributedCompany");

                    b.Navigation("ItemType");

                    b.Navigation("TheManufacturer");
                });

            modelBuilder.Entity("Pharmacy.domain.ItemBarcode", b =>
                {
                    b.HasOne("Pharmacy.domain.Item", "Item")
                        .WithMany("ItemBarcodes")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Pharmacy.domain.ItemUnit", b =>
                {
                    b.HasOne("Pharmacy.domain.Item", "Item")
                        .WithMany("ItemUnits")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.domain.Unit", "Unit")
                        .WithMany("ItemUnits")
                        .HasForeignKey("unitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Pharmacy.domain.PuchasingBillDetails", b =>
                {
                    b.HasOne("Pharmacy.domain.Item", "Item")
                        .WithMany()
                        .HasForeignKey("itemId");

                    b.HasOne("Pharmacy.domain.PurchasingBill", "PurchasingBill")
                        .WithMany("PuchasingBillDetails")
                        .HasForeignKey("purchasingbillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.domain.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("unitId");

                    b.Navigation("Item");

                    b.Navigation("PurchasingBill");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Pharmacy.domain.PurchasingBill", b =>
                {
                    b.HasOne("Pharmacy.domain.Representer", "Representer")
                        .WithMany("PurchasingBill")
                        .HasForeignKey("representerId");

                    b.HasOne("Pharmacy.domain.ApplicationUser", "ApplicationUser")
                        .WithMany("PurchasingBills")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Representer");
                });

            modelBuilder.Entity("Pharmacy.domain.Representer", b =>
                {
                    b.HasOne("Pharmacy.domain.DistributedCompany", "DistributedCompany")
                        .WithMany("Representers")
                        .HasForeignKey("distributed_Company_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DistributedCompany");
                });

            modelBuilder.Entity("Pharmacy.domain.SellingBill", b =>
                {
                    b.HasOne("Pharmacy.domain.ApplicationUser", "ApplicationUser")
                        .WithMany("SellingBills")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Pharmacy.domain.SellingBillDetails", b =>
                {
                    b.HasOne("Pharmacy.domain.Item", "Item")
                        .WithMany("SellingBillDetails")
                        .HasForeignKey("itemId");

                    b.HasOne("Pharmacy.domain.SellingBill", "SellingBill")
                        .WithMany("SellingBillDetails")
                        .HasForeignKey("sellingbillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.domain.Unit", "Unit")
                        .WithMany("SellingBillDetails")
                        .HasForeignKey("unitId");

                    b.Navigation("Item");

                    b.Navigation("SellingBill");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Pharmacy.domain.ApplicationUser", b =>
                {
                    b.Navigation("DataWarehouses");

                    b.Navigation("Items");

                    b.Navigation("PurchasingBills");

                    b.Navigation("SellingBills");
                });

            modelBuilder.Entity("Pharmacy.domain.DistributedCompany", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Representers");
                });

            modelBuilder.Entity("Pharmacy.domain.Item", b =>
                {
                    b.Navigation("DataWarehouses");

                    b.Navigation("ItemBarcodes");

                    b.Navigation("ItemUnits");

                    b.Navigation("SellingBillDetails");
                });

            modelBuilder.Entity("Pharmacy.domain.ItemBarcode", b =>
                {
                    b.Navigation("DataWarehouses");
                });

            modelBuilder.Entity("Pharmacy.domain.ItemType", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Pharmacy.domain.ItemUnit", b =>
                {
                    b.Navigation("DataWarehouses");
                });

            modelBuilder.Entity("Pharmacy.domain.PurchasingBill", b =>
                {
                    b.Navigation("PuchasingBillDetails");
                });

            modelBuilder.Entity("Pharmacy.domain.Representer", b =>
                {
                    b.Navigation("PurchasingBill");
                });

            modelBuilder.Entity("Pharmacy.domain.SellingBill", b =>
                {
                    b.Navigation("SellingBillDetails");
                });

            modelBuilder.Entity("Pharmacy.domain.TheManufacturer", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("distributedCompanies");
                });

            modelBuilder.Entity("Pharmacy.domain.Unit", b =>
                {
                    b.Navigation("ItemUnits");

                    b.Navigation("SellingBillDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
