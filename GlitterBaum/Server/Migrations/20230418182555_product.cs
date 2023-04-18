using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlitterBaum.Server.Migrations
{
    /// <inheritdoc />
    public partial class product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUrl",
                value: "https://scontent-sjc3-1.cdninstagram.com/v/t51.2885-15/315995136_863068194706104_1965398170283550724_n.jpg?stp=dst-jpg_e35_p640x640_sh0.08&_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=100&_nc_ohc=uE-QfNlESzgAX86jvbT&edm=ALQROFkBAAAA&ccb=7-5&ig_cache_key=Mjk3MzI3NTg3OTA5NTU2OTY2OA%3D%3D.2-ccb7-5&oh=00_AfAbfkolXM0lY8qqlJCxExo46DqoQkxlGRLg0X0ikkNRsA&oe=64439F2B&_nc_sid=30a2ef");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg");
        }
    }
}
