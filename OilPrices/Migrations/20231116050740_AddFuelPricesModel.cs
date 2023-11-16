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
                name: "FuelStations",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false),
                    NAZWA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ADRES = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MIEJSCOWOSC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KODPOCZTOWY = table.Column<string>(name: "KOD_POCZTOWY", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WOJEWODZTWO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    POWIAT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RON95 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RON98 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ON = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LPG = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelStations", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelStations");
        }
    }
}
