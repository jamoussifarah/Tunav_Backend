using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TunavBackend.Migrations
{
    /// <inheritdoc />
    public partial class MakeProduitAvecDevisIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_ProduitsAvecDevis_ProduitAvecDevisId",
                table: "Devis");

            migrationBuilder.AlterColumn<int>(
                name: "ProduitAvecDevisId",
                table: "Devis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_ProduitsAvecDevis_ProduitAvecDevisId",
                table: "Devis",
                column: "ProduitAvecDevisId",
                principalTable: "ProduitsAvecDevis",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_ProduitsAvecDevis_ProduitAvecDevisId",
                table: "Devis");

            migrationBuilder.AlterColumn<int>(
                name: "ProduitAvecDevisId",
                table: "Devis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_ProduitsAvecDevis_ProduitAvecDevisId",
                table: "Devis",
                column: "ProduitAvecDevisId",
                principalTable: "ProduitsAvecDevis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
