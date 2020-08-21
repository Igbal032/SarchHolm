using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchHolm.Migrations
{
    public partial class second1225 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgPathForPlace",
                table: "apartments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgPathForPlace",
                table: "apartments");
        }
    }
}
