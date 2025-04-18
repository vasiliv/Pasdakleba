using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Sales");

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "BrandId", "Description", "EndDate", "ImageUrl", "Priority", "SaleTypeId", "StartDate" },
                values: new object[] { 1, 1, "🥥 ქოქოსი 1ც. - 2.29₾ ნაცვლად 3.50₾-ისა\r\n🥑 ავოკადო 1ც. - 2.69₾ ნაცვლად 3.95₾-ისა\r\n🥭 მანგო 1ც. - 2.99₾ ნაცვლად 4.75₾-ისა\r\n🍊 პომელო 1ც. - 5.49₾ ნაცვლად 8.50₾-ისა", new DateOnly(2024, 12, 31), "www.pasdakleba.ge/1.jpg", 1, 1, new DateOnly(2024, 3, 1) });
        }
    }
}
