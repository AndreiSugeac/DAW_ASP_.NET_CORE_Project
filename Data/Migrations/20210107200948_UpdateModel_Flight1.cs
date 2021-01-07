using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketLine.Data.Migrations
{
    public partial class UpdateModel_Flight1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight");

            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight");

            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight");

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight",
                column: "BoardingId",
                principalTable: "Airport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight",
                column: "DestinationId",
                principalTable: "Airport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
