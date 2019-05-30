using Microsoft.EntityFrameworkCore.Migrations;

namespace Auction.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "born",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Users",
                newName: "otc");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Users",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "fam",
                table: "Users",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Users",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "fam",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "born");

            migrationBuilder.RenameColumn(
                name: "otc",
                table: "Users",
                newName: "Country");
        }
    }
}
