using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Persistence.Migrations
{
    public partial class intialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    isAdmin = table.Column<int>(type: "int", nullable: true),
                    lastloginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    timeCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "('true')"),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "itemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheManufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheManufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sellingBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<int>(type: "int", nullable: false),
                    tax = table.Column<int>(type: "int", nullable: false),
                    timeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellingBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sellingBills_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistributedCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheManufacturerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributedCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistributedCompany_TheManufacturer_TheManufacturerId",
                        column: x => x.TheManufacturerId,
                        principalTable: "TheManufacturer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tradeNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tradeNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chemicalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    molality = table.Column<int>(type: "int", nullable: true),
                    duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    buyingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    sellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    itemtypeId = table.Column<int>(type: "int", nullable: true),
                    manufactureId = table.Column<int>(type: "int", nullable: true),
                    distributedId = table.Column<int>(type: "int", nullable: true),
                    TheManufacturerId = table.Column<int>(type: "int", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_DistributedCompany_distributedId",
                        column: x => x.distributedId,
                        principalTable: "DistributedCompany",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_itemTypes_itemtypeId",
                        column: x => x.itemtypeId,
                        principalTable: "itemTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_TheManufacturer_TheManufacturerId",
                        column: x => x.TheManufacturerId,
                        principalTable: "TheManufacturer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "representers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    distributed_Company_Id = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_representers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_representers_DistributedCompany_distributed_Company_Id",
                        column: x => x.distributed_Company_Id,
                        principalTable: "DistributedCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itemBarcodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemId = table.Column<int>(type: "int", nullable: false),
                    productionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    codeGenerated = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemBarcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itemBarcodes_Item_itemId",
                        column: x => x.itemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itemUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemId = table.Column<int>(type: "int", nullable: false),
                    unitId = table.Column<int>(type: "int", nullable: false),
                    quantityContent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itemUnits_Item_itemId",
                        column: x => x.itemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itemUnits_units_unitId",
                        column: x => x.unitId,
                        principalTable: "units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sellingBillDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sellingbillId = table.Column<int>(type: "int", nullable: false),
                    itemId = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    unitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellingBillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sellingBillDetails_Item_itemId",
                        column: x => x.itemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_sellingBillDetails_sellingBills_sellingbillId",
                        column: x => x.sellingbillId,
                        principalTable: "sellingBills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sellingBillDetails_units_unitId",
                        column: x => x.unitId,
                        principalTable: "units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "purchasingBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<int>(type: "int", nullable: false),
                    tax = table.Column<int>(type: "int", nullable: false),
                    timeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    representerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchasingBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchasingBills_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchasingBills_representers_representerId",
                        column: x => x.representerId,
                        principalTable: "representers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "dataWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemId = table.Column<int>(type: "int", nullable: true),
                    sellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    buyingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    itemunitId = table.Column<int>(type: "int", nullable: true),
                    itembarcodeId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    timeCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dataWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dataWarehouses_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_dataWarehouses_Item_itemId",
                        column: x => x.itemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_dataWarehouses_itemBarcodes_itembarcodeId",
                        column: x => x.itembarcodeId,
                        principalTable: "itemBarcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dataWarehouses_itemUnits_itemunitId",
                        column: x => x.itemunitId,
                        principalTable: "itemUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "puchasingBillDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemId = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    unitId = table.Column<int>(type: "int", nullable: true),
                    purchasingbillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_puchasingBillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_puchasingBillDetails_Item_itemId",
                        column: x => x.itemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_puchasingBillDetails_purchasingBills_purchasingbillId",
                        column: x => x.purchasingbillId,
                        principalTable: "purchasingBills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_puchasingBillDetails_units_unitId",
                        column: x => x.unitId,
                        principalTable: "units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_dataWarehouses_itembarcodeId",
                table: "dataWarehouses",
                column: "itembarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_dataWarehouses_itemId",
                table: "dataWarehouses",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_dataWarehouses_itemunitId",
                table: "dataWarehouses",
                column: "itemunitId");

            migrationBuilder.CreateIndex(
                name: "IX_dataWarehouses_userId",
                table: "dataWarehouses",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributedCompany_TheManufacturerId",
                table: "DistributedCompany",
                column: "TheManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ApplicationUserId",
                table: "Item",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_distributedId",
                table: "Item",
                column: "distributedId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_itemtypeId",
                table: "Item",
                column: "itemtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TheManufacturerId",
                table: "Item",
                column: "TheManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_itemBarcodes_itemId",
                table: "itemBarcodes",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_itemUnits_itemId",
                table: "itemUnits",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_itemUnits_unitId",
                table: "itemUnits",
                column: "unitId");

            migrationBuilder.CreateIndex(
                name: "IX_puchasingBillDetails_itemId",
                table: "puchasingBillDetails",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_puchasingBillDetails_purchasingbillId",
                table: "puchasingBillDetails",
                column: "purchasingbillId");

            migrationBuilder.CreateIndex(
                name: "IX_puchasingBillDetails_unitId",
                table: "puchasingBillDetails",
                column: "unitId");

            migrationBuilder.CreateIndex(
                name: "IX_purchasingBills_representerId",
                table: "purchasingBills",
                column: "representerId");

            migrationBuilder.CreateIndex(
                name: "IX_purchasingBills_userId",
                table: "purchasingBills",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_representers_distributed_Company_Id",
                table: "representers",
                column: "distributed_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_sellingBillDetails_itemId",
                table: "sellingBillDetails",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_sellingBillDetails_sellingbillId",
                table: "sellingBillDetails",
                column: "sellingbillId");

            migrationBuilder.CreateIndex(
                name: "IX_sellingBillDetails_unitId",
                table: "sellingBillDetails",
                column: "unitId");

            migrationBuilder.CreateIndex(
                name: "IX_sellingBills_userId",
                table: "sellingBills",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "dataWarehouses");

            migrationBuilder.DropTable(
                name: "puchasingBillDetails");

            migrationBuilder.DropTable(
                name: "sellingBillDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "itemBarcodes");

            migrationBuilder.DropTable(
                name: "itemUnits");

            migrationBuilder.DropTable(
                name: "purchasingBills");

            migrationBuilder.DropTable(
                name: "sellingBills");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "units");

            migrationBuilder.DropTable(
                name: "representers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "itemTypes");

            migrationBuilder.DropTable(
                name: "DistributedCompany");

            migrationBuilder.DropTable(
                name: "TheManufacturer");
        }
    }
}
