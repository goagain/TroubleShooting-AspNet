using Microsoft.EntityFrameworkCore.Migrations;

namespace TroubleShooting_AspNet.Migrations
{
    public partial class ChangeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstName",
                table: "assistanceRequest");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "assistanceRequest",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "postcode",
                table: "assistanceRequest",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "assistanceRequest",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "assistanceRequest",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "assistanceRequest",
                newName: "postcode");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "assistanceRequest",
                newName: "lastName");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "assistanceRequest",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
