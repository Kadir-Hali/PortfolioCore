using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCore.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Contacts",
                newName: "ContactTitle");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Contacts",
                newName: "ContactIcon");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "ContactDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactTitle",
                table: "Contacts",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ContactIcon",
                table: "Contacts",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "ContactDescription",
                table: "Contacts",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
