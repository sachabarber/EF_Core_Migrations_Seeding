using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Migrations.DemoApp.Migrations
{
    public partial class BlogSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "CreatedDate", "Url" },
                values: new object[] { 1, "21/08/2018", "http://9fdc10f5-293d-488f-9f91-695f863b8bca.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1);
        }
    }
}
