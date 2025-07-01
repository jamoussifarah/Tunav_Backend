using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TunavBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddFranchise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ville",
                table: "Franchises",
                newName: "Telephone");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Franchises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntrepriseDirige",
                table: "Franchises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExperienceIotGps",
                table: "Franchises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Motivation",
                table: "Franchises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prenom",
                table: "Franchises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfessionActuelle",
                table: "Franchises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Franchises");

            migrationBuilder.DropColumn(
                name: "EntrepriseDirige",
                table: "Franchises");

            migrationBuilder.DropColumn(
                name: "ExperienceIotGps",
                table: "Franchises");

            migrationBuilder.DropColumn(
                name: "Motivation",
                table: "Franchises");

            migrationBuilder.DropColumn(
                name: "Prenom",
                table: "Franchises");

            migrationBuilder.DropColumn(
                name: "ProfessionActuelle",
                table: "Franchises");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Franchises",
                newName: "Ville");
        }
    }
}
