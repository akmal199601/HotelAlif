using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelAlif.Migrations
{
    public partial class EditForignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberId",
                table: "Scores");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Scores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scores_RoomId",
                table: "Scores",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Rooms_RoomId",
                table: "Scores",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Rooms_RoomId",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_RoomId",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Scores");

            migrationBuilder.AddColumn<int>(
                name: "NumberId",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
