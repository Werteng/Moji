using Microsoft.EntityFrameworkCore.Migrations;

namespace Moji.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(nullable: true),
                    MultiMana = table.Column<float>(nullable: false),
                    MultiSante = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(nullable: true),
                    Degat = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IdClasse = table.Column<int>(nullable: false),
                    ClasseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arme_Classe_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sort",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(nullable: true),
                    Cout = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Degat = table.Column<int>(nullable: false),
                    IdClasse = table.Column<int>(nullable: false),
                    ClasseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sort", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sort_Classe_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personnages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    AvatarUrl = table.Column<string>(nullable: true),
                    Or = table.Column<float>(nullable: false),
                    SanteActuel = table.Column<float>(nullable: false),
                    SanteMax = table.Column<float>(nullable: false),
                    ManaActuel = table.Column<float>(nullable: false),
                    ManaMax = table.Column<float>(nullable: false),
                    Xp = table.Column<float>(nullable: false),
                    Niveau = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    IdRace = table.Column<int>(nullable: false),
                    RaceId = table.Column<int>(nullable: true),
                    IdClasse = table.Column<int>(nullable: false),
                    ClasseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnages_Classe_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnages_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arme_ClasseId",
                table: "Arme",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnages_ClasseId",
                table: "Personnages",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnages_RaceId",
                table: "Personnages",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Sort_ClasseId",
                table: "Sort",
                column: "ClasseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arme");

            migrationBuilder.DropTable(
                name: "Personnages");

            migrationBuilder.DropTable(
                name: "Sort");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Classe");
        }
    }
}
