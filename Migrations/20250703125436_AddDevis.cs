using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TunavBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddDevis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ProduitsSansDevis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Devis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entreprise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProduitAvecDevisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devis_ProduitsAvecDevis_ProduitAvecDevisId",
                        column: x => x.ProduitAvecDevisId,
                        principalTable: "ProduitsAvecDevis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProduitsSansDevis_UserId",
                table: "ProduitsSansDevis",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Devis_ProduitAvecDevisId",
                table: "Devis",
                column: "ProduitAvecDevisId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitsSansDevis_Users_UserId",
                table: "ProduitsSansDevis",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProduitsSansDevis_Users_UserId",
                table: "ProduitsSansDevis");

            migrationBuilder.DropTable(
                name: "Devis");

            migrationBuilder.DropIndex(
                name: "IX_ProduitsSansDevis_UserId",
                table: "ProduitsSansDevis");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProduitsSansDevis");
        }
    }
}
