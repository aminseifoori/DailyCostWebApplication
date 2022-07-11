using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyCostWebApplication.Migrations
{
    public partial class AddOnDeleteBehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Costs_Categories_CategoryID",
                table: "Costs");

            migrationBuilder.AddForeignKey(
                name: "FK_Costs_Categories_CategoryID",
                table: "Costs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Costs_Categories_CategoryID",
                table: "Costs");

            migrationBuilder.AddForeignKey(
                name: "FK_Costs_Categories_CategoryID",
                table: "Costs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
