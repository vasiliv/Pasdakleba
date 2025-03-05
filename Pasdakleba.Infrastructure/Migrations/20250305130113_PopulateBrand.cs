using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PopulateBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Sales_SaleId",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_SaleId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Brands");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "NameEng", "NameGeo", "Priority" },
                values: new object[,]
                {
                    { 1, "Nikora", "ნიკორა", 0 },
                    { 2, "2Nabiji", "2 ნაბიჯი", 0 },
                    { 3, "Spar", "სპარი", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BrandId",
                table: "Sales",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Brands_BrandId",
                table: "Sales",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Brands_BrandId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_BrandId",
                table: "Sales");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_SaleId",
                table: "Brands",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Sales_SaleId",
                table: "Brands",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
