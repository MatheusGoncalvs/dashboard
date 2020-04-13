using Microsoft.EntityFrameworkCore.Migrations;

namespace dashboard.Data.Migrations
{
    public partial class addClaimNomeCompleto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeCompleto",
                table: "AspNetUsers");
        }
    }
}
