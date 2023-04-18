using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlitterBaum.Server.Migrations
{
    /// <inheritdoc />
    public partial class productimg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImgUrl", "Title" },
                values: new object[] { "", "Stranger-Things-Ornament.jpg", "Stranger Things Ornament" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImgUrl", "Title" },
                values: new object[] { "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", "Images/Stranger-Things_Ornament.jpg", "The Hitchhiker's Guide to the Galaxy" });
        }
    }
}
