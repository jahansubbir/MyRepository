using Microsoft.EntityFrameworkCore.Migrations;

namespace BDCounterEtokenSystem.Migrations
{
    public partial class CounterModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoothCount",
                table: "Counters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoothCount",
                table: "Counters");
        }
    }
}
