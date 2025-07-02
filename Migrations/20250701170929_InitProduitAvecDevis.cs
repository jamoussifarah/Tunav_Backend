using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TunavBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitProduitAvecDevis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProduitsAvecDevis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitsAvecDevis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristiquesProduitAvecDevis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProduitAvecDevisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristiquesProduitAvecDevis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaracteristiquesProduitAvecDevis_ProduitsAvecDevis_ProduitAvecDevisId",
                        column: x => x.ProduitAvecDevisId,
                        principalTable: "ProduitsAvecDevis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristiquesProduitAvecDevis_ProduitAvecDevisId",
                table: "CaracteristiquesProduitAvecDevis",
                column: "ProduitAvecDevisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaracteristiquesProduitAvecDevis");

            migrationBuilder.DropTable(
                name: "ProduitsAvecDevis");
        }
    }
}
