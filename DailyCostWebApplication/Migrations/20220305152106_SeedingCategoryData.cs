using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyCostWebApplication.Migrations
{
    public partial class SeedingCategoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "CategoryName", "Description" },
                values: new object[] { 1, 0, "Bill", "This categoroy is assigned for recording Bill cost" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "CategoryName", "Description" },
                values: new object[] { 2, 0, "Gerocery", "This categoroy is assigned for recording Gerocery cost" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
