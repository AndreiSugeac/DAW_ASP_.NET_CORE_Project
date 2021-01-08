using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketLine.Data.Migrations
{
    public partial class UpdateModel_Airplane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Airplane_FlightId",
                table: "Airplane",
                column: "FlightId",
                unique: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Airplane_Flight_FlightId",
                table: "Airplane",
                column: "FlightId",
                principalTable: "Flight",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetDefault);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airplane_Flight_FlightId",
                table: "Airplane");

            migrationBuilder.DropIndex(
                name: "IX_Airplane_FlightId",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Airplane");
        }
    }
}
