using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Carrefur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Carrefour", "კარფური" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Magniti", "მაგნიტი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Nikora", "ნიკორა" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Spar", "სპარი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Fresco", "ფრესკო" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "NameEng", "NameGeo", "Priority" },
                values: new object[] { 7, "Other", "სხვა", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Magniti", "მაგნიტი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Nikora", "ნიკორა" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Spar", "სპარი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Fresco", "ფრესკო" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Other", "სხვა" });
        }
    }
}
