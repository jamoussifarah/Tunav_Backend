using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TunavBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddEtatToDevis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Etat",
                table: "Devis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Etat",
                table: "Devis");
        }
    }
}
