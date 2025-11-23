using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
    name: "Nume",
    table: "AspNetUsers",
    nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CNP",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "AspNetUsers",
                nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Nume", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Prenume", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "CNP", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Adresa", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Telefon", table: "AspNetUsers");

        }
    }
}
