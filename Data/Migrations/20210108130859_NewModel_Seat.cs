using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketLine.Data.Migrations
{
    public partial class NewModel_Seat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight");

            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight");

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirplaneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seat_Airplane_AirplaneId",
                        column: x => x.AirplaneId,
                        principalTable: "Airplane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seat_AirplaneId",
                table: "Seat",
                column: "AirplaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight",
                column: "BoardingId",
                principalTable: "Airport",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight",
                column: "DestinationId",
                principalTable: "Airport",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight");

            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight",
                column: "BoardingId",
                principalTable: "Airport",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight",
                column: "DestinationId",
                principalTable: "Airport",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
