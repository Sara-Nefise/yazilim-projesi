using Microsoft.EntityFrameworkCore.Migrations;

namespace ImuSeyahat.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(maxLength: 50, nullable: false),
                    CityName = table.Column<string>(nullable: false),
                    PlaceAdress = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    PlaceEmail = table.Column<string>(nullable: false),
                    OpeningTime = table.Column<string>(nullable: false),
                    ClosingTime = table.Column<string>(nullable: false),
                    EntranceFee = table.Column<double>(nullable: false),
                    PlaceDescription = table.Column<string>(nullable: false),
                    ImageURL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_places", x => x.PlaceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "places");
        }
    }
}
