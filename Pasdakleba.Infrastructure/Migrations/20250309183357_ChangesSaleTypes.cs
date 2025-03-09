using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangesSaleTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Shoes And Clothing", "ტანსაცმელი და ფეხსაცმელი" });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "NameEng", "NameGeo" },
                values: new object[] { 5, "Various", "სხვადასხვა" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Various", "სხვადასხვა" });
        }
    }
}
