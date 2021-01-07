using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketLine.Data.Migrations
{
    public partial class UpdateModel_Flight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight");

            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "Flight",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BoardingId",
                table: "Flight",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight",
                column: "BoardingId",
                principalTable: "Airport",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight",
                column: "DestinationId",
                principalTable: "Airport",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight");

            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "Flight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BoardingId",
                table: "Flight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_BoardingId",
                table: "Flight",
                column: "BoardingId",
                principalTable: "Airport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_DestinationId",
                table: "Flight",
                column: "DestinationId",
                principalTable: "Airport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
