using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieFinder.Data.Migrations
{
    public partial class RegistirationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAd",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserSoyad",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserSoyad",
                table: "AspNetUsers");
        }
    }
}
