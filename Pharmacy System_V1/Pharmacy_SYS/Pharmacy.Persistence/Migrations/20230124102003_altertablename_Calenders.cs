using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Persistence.Migrations
{
    public partial class altertablename_Calenders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Calender_clenderId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Calender");

            migrationBuilder.CreateTable(
                name: "Calenders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calenders", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Calenders_clenderId",
                table: "Item",
                column: "clenderId",
                principalTable: "Calenders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Calenders_clenderId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Calenders");

            migrationBuilder.CreateTable(
                name: "Calender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calender", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Calender_clenderId",
                table: "Item",
                column: "clenderId",
                principalTable: "Calender",
                principalColumn: "Id");
        }
    }
}
