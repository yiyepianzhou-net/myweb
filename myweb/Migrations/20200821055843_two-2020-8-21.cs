using Microsoft.EntityFrameworkCore.Migrations;

namespace myweb.Migrations
{
    public partial class two2020821 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoomId",
                table: "users",
                maxLength: 8,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    RoomID = table.Column<string>(maxLength: 8, nullable: false),
                    RoomName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.RoomID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_RoomId",
                table: "users",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_rooms_RoomId",
                table: "users",
                column: "RoomId",
                principalTable: "rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_rooms_RoomId",
                table: "users");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropIndex(
                name: "IX_users_RoomId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "users");
        }
    }
}
