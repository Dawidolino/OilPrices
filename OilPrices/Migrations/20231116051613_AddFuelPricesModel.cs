using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OilPrices.Migrations
{
    /// <inheritdoc />
    public partial class AddFuelPricesModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FuelPrices",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelStationId = table.Column<short>(type: "smallint", nullable: false),
                    RON95 = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    RON98 = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ON = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    LPG = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    PriceEditDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelPrices_FuelStations_FuelStationId",
                        column: x => x.FuelStationId,
                        principalTable: "FuelStations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FuelPrices_FuelStationId",
                table: "FuelPrices",
                column: "FuelStationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelPrices");
        }
    }
}
