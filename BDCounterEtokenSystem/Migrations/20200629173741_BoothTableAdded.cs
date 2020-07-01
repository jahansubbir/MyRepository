using Microsoft.EntityFrameworkCore.Migrations;

namespace BDCounterEtokenSystem.Migrations
{
    public partial class BoothTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booth_Counters_CounterId",
                table: "Booth");

            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Booth_BoothId",
                table: "Tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booth",
                table: "Booth");

            migrationBuilder.RenameTable(
                name: "Booth",
                newName: "Booths");

            migrationBuilder.RenameIndex(
                name: "IX_Booth_CounterId",
                table: "Booths",
                newName: "IX_Booths_CounterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booths",
                table: "Booths",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booths_Counters_CounterId",
                table: "Booths",
                column: "CounterId",
                principalTable: "Counters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Booths_BoothId",
                table: "Tokens",
                column: "BoothId",
                principalTable: "Booths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booths_Counters_CounterId",
                table: "Booths");

            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Booths_BoothId",
                table: "Tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booths",
                table: "Booths");

            migrationBuilder.RenameTable(
                name: "Booths",
                newName: "Booth");

            migrationBuilder.RenameIndex(
                name: "IX_Booths_CounterId",
                table: "Booth",
                newName: "IX_Booth_CounterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booth",
                table: "Booth",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booth_Counters_CounterId",
                table: "Booth",
                column: "CounterId",
                principalTable: "Counters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Booth_BoothId",
                table: "Tokens",
                column: "BoothId",
                principalTable: "Booth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
