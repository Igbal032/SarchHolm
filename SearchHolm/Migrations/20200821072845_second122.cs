using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchHolm.Migrations
{
    public partial class second122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgPathMin",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgPathMin",
                table: "AspNetUsers");
        }
    }
}
