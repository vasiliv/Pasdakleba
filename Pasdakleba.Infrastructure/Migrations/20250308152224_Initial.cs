using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pasdakleba.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    NameGeo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEng = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGeo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEng = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    SaleTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_SaleType_SaleTypeId",
                        column: x => x.SaleTypeId,
                        principalTable: "SaleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "NameEng", "NameGeo", "Priority" },
                values: new object[,]
                {
                    { 1, "Nikora", "ნიკორა", 0 },
                    { 2, "2Nabiji", "2 ნაბიჯი", 0 },
                    { 3, "Spar", "სპარი", 0 }
                });

            migrationBuilder.InsertData(
                table: "SaleType",
                columns: new[] { "Id", "NameEng", "NameGeo" },
                values: new object[,]
                {
                    { 1, "Food", "საკვები პროდუქტები" },
                    { 2, "Drinks", "სასმელი" },
                    { 3, "Technique", "ტექნიკა" },
                    { 4, "Various", "სხვადასხვა" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "BrandId", "Description", "EndDate", "ImageUrl", "Priority", "SaleTypeId", "StartDate" },
                values: new object[] { 1, 1, "🥥 ქოქოსი 1ც. - 2.29₾ ნაცვლად 3.50₾-ისა\r\n🥑 ავოკადო 1ც. - 2.69₾ ნაცვლად 3.95₾-ისა\r\n🥭 მანგო 1ც. - 2.99₾ ნაცვლად 4.75₾-ისა\r\n🍊 პომელო 1ც. - 5.49₾ ნაცვლად 8.50₾-ისა", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "www.pasdakleba.ge/1.jpg", 1, 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BrandId",
                table: "Sales",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SaleTypeId",
                table: "Sales",
                column: "SaleTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "SaleType");
        }
    }
}
