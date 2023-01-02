using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Persistence.Migrations
{
    public partial class add_column_InItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity_Trade_Bar",
                table: "Item",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity_Trade_Bar",
                table: "Item");
        }
    }
}
