using Microsoft.EntityFrameworkCore.Migrations;

namespace Auction.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bits_Lots_LotId1",
                table: "Bits");

            migrationBuilder.DropIndex(
                name: "IX_Bits_LotId1",
                table: "Bits");

            migrationBuilder.DropColumn(
                name: "LotId1",
                table: "Bits");

            migrationBuilder.AlterColumn<int>(
                name: "LotId",
                table: "Bits",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bits_LotId",
                table: "Bits",
                column: "LotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bits_Lots_LotId",
                table: "Bits",
                column: "LotId",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bits_Lots_LotId",
                table: "Bits");

            migrationBuilder.DropIndex(
                name: "IX_Bits_LotId",
                table: "Bits");

            migrationBuilder.AlterColumn<string>(
                name: "LotId",
                table: "Bits",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LotId1",
                table: "Bits",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bits_LotId1",
                table: "Bits",
                column: "LotId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bits_Lots_LotId1",
                table: "Bits",
                column: "LotId1",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
