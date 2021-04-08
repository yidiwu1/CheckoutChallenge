using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPayment.Server.Migrations
{
    public partial class _3dscodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MD",
                table: "Payment",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaRes",
                table: "Payment",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MD",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaRes",
                table: "Payment");
        }
    }
}
