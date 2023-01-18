using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Persistence.Migrations
{
    public partial class changeitemnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "itemNo",
                table: "Item",
                newName: "batchNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "batchNo",
                table: "Item",
                newName: "itemNo");
        }
    }
}
