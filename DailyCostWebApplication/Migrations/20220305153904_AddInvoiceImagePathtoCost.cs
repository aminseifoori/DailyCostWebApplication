using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyCostWebApplication.Migrations
{
    public partial class AddInvoiceImagePathtoCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvoiceImagePath",
                table: "Costs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceImagePath",
                table: "Costs");
        }
    }
}
