using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketLine.Data.Migrations
{
    public partial class OneToMany_ApplicationUser_Ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Ticket",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_OwnerId",
                table: "Ticket",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_OwnerId",
                table: "Ticket",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_OwnerId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_OwnerId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Ticket");
        }
    }
}
