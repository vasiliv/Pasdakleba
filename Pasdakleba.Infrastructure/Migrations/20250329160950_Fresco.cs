using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fresco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "2Nabiji", "2 ნაბიჯი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Nikora", "ნიკორა" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Fresco", "ფრესკო" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "NameEng", "NameGeo", "Priority" },
                values: new object[] { 5, "Other", "სხვა", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Nikora", "ნიკორა" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "2Nabiji", "2 ნაბიჯი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Other", "სხვა" });
        }
    }
}
