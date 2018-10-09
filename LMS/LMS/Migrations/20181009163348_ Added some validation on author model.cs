using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class Addedsomevalidationonauthormodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DisplayedName",
                table: "Author",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_LicensePlate",
                table: "Author",
                column: "DisplayedName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_LicensePlate",
                table: "Author");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayedName",
                table: "Author",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
