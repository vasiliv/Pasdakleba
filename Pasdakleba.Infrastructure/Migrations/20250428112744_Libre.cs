using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Libre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Libre", "ლიბრე" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Magniti", "მაგნიტი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Nikora", "ნიკორა" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Spar", "სპარი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "SuptaSakhli", "სუფთა სახლი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Fresco", "ფრესკო" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "NameEng", "NameGeo", "Priority" },
                values: new object[] { 10, "Other", "სხვა", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Magniti", "მაგნიტი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Nikora", "ნიკორა" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Spar", "სპარი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "SuptaSakhli", "სუფთა სახლი" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Fresco", "ფრესკო" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NameEng", "NameGeo" },
                values: new object[] { "Other", "სხვა" });
        }
    }
}
