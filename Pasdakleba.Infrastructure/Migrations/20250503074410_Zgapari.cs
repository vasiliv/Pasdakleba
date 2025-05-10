using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Zgapari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "NameEng", "NameGeo", "Priority" },
                values: new object[] { 13, "Zgapari", "ზღაპარი", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
