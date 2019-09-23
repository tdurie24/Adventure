using Microsoft.EntityFrameworkCore.Migrations;

namespace Adventure.Data.Migrations
{
    public partial class imageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SourceURL",
                table: "Images",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceURL",
                table: "Images");
        }
    }
}
