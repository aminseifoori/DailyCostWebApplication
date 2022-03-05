using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyCostWebApplication.Migrations
{
    public partial class AddingMoreSeedDatatoCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "CategoryName", "Description" },
                values: new object[] { 3, 0, "Rent", "This categoroy is assigned for recording Rental cost" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
