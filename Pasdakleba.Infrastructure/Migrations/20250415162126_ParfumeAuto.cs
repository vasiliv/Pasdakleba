using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ParfumeAuto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEng", "NameGeo", "Url" },
                values: new object[] { "Parfume And Cleanery", "პარფიუმერია და სისუფთავე", "/parfumeandcleanery" });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "NameEng", "NameGeo", "Url" },
                values: new object[,]
                {
                    { 6, "Auto/Moto", "ავტო/მოტო", "/automoto" },
                    { 7, "Various", "სხვადასხვა", "/various" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEng", "NameGeo", "Url" },
                values: new object[] { "Various", "სხვადასხვა", "/various" });
        }
    }
}
