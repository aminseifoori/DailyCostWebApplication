using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyCostWebApplication.Migrations
{
    public partial class RelationshipCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Costs_CategoryID",
                table: "Costs");

            migrationBuilder.CreateIndex(
                name: "IX_Costs_CategoryID",
                table: "Costs",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Costs_CategoryID",
                table: "Costs");

            migrationBuilder.CreateIndex(
                name: "IX_Costs_CategoryID",
                table: "Costs",
                column: "CategoryID",
                unique: true);
        }
    }
}
