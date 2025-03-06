using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedSale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "BrandId", "Description", "EndDate", "ImageUrl", "Priority", "StartDate" },
                values: new object[] { 1, 1, "🥥 ქოქოსი 1ც. - 2.29₾ ნაცვლად 3.50₾-ისა\r\n🥑 ავოკადო 1ც. - 2.69₾ ნაცვლად 3.95₾-ისა\r\n🥭 მანგო 1ც. - 2.99₾ ნაცვლად 4.75₾-ისა\r\n🍊 პომელო 1ც. - 5.49₾ ნაცვლად 8.50₾-ისა", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "www.pasdakleba.ge/1.jpg", 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
