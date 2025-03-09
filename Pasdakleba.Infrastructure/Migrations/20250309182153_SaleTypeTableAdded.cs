using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SaleTypeTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_SaleType_SaleTypeId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleType",
                table: "SaleType");

            migrationBuilder.RenameTable(
                name: "SaleType",
                newName: "SaleTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleTypes",
                table: "SaleTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_SaleTypes_SaleTypeId",
                table: "Sales",
                column: "SaleTypeId",
                principalTable: "SaleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_SaleTypes_SaleTypeId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleTypes",
                table: "SaleTypes");

            migrationBuilder.RenameTable(
                name: "SaleTypes",
                newName: "SaleType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleType",
                table: "SaleType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_SaleType_SaleTypeId",
                table: "Sales",
                column: "SaleTypeId",
                principalTable: "SaleType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
