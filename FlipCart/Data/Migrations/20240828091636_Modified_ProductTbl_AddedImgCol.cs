using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlipCart.Data.Migrations
{
    /// <inheritdoc />
    public partial class Modified_ProductTbl_AddedImgCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "TblProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "TblProduct");
        }
    }
}
