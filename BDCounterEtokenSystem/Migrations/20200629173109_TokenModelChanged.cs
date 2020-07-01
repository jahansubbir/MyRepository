using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BDCounterEtokenSystem.Migrations
{
    public partial class TokenModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoothId",
                table: "Tokens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Booth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CounterId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booth_Counters_CounterId",
                        column: x => x.CounterId,
                        principalTable: "Counters",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_BoothId",
                table: "Tokens",
                column: "BoothId");

            migrationBuilder.CreateIndex(
                name: "IX_Booth_CounterId",
                table: "Booth",
                column: "CounterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Booth_BoothId",
                table: "Tokens",
                column: "BoothId",
                principalTable: "Booth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Booth_BoothId",
                table: "Tokens");

            migrationBuilder.DropTable(
                name: "Booth");

            migrationBuilder.DropIndex(
                name: "IX_Tokens_BoothId",
                table: "Tokens");

            migrationBuilder.DropColumn(
                name: "BoothId",
                table: "Tokens");
        }
    }
}
