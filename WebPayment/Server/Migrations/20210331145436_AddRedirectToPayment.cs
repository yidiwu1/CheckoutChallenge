using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPayment.Server.Migrations
{
    public partial class AddRedirectToPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RedirectData",
                table: "Payment",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RedirectData",
                table: "Payment");
        }
    }
}
