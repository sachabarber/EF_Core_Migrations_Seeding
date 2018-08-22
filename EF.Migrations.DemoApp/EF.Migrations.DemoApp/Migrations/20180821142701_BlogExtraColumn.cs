using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Migrations.DemoApp.Migrations
{
    public partial class BlogExtraColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Blogs",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Blogs");
        }
    }
}
