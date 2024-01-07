using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OilPrices.Migrations
{
    /// <inheritdoc />
    public partial class AddLatLongToFuelStation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuelPrices_FuelStations_FuelStationId",
                table: "FuelPrices");

            migrationBuilder.DropIndex(
                name: "IX_FuelPrices_FuelStationId",
                table: "FuelPrices");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "FuelStations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "FuelStations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "FuelStations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "FuelStations");

            migrationBuilder.CreateIndex(
                name: "IX_FuelPrices_FuelStationId",
                table: "FuelPrices",
                column: "FuelStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuelPrices_FuelStations_FuelStationId",
                table: "FuelPrices",
                column: "FuelStationId",
                principalTable: "FuelStations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
