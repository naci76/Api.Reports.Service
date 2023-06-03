using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Reports.Entitiy.Migrations
{
    public partial class konumalanlarieklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lat",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lon",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Lon",
                table: "Reports");
        }
    }
}
