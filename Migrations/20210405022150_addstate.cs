using Microsoft.EntityFrameworkCore.Migrations;

namespace TroubleShooting_AspNet.Migrations
{
    public partial class addstate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "state",
                table: "assistanceRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "state",
                table: "assistanceRequest");
        }
    }
}
