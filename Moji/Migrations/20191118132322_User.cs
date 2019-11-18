using Microsoft.EntityFrameworkCore.Migrations;

namespace Moji.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Personnages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Personnages",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(nullable: true),
                    motDePasse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personnages_UserId",
                table: "Personnages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnages_User_UserId",
                table: "Personnages",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnages_User_UserId",
                table: "Personnages");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Personnages_UserId",
                table: "Personnages");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Personnages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Personnages");
        }
    }
}
