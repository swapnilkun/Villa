using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmazonApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MobNo = table.Column<long>(type: "bigint", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUsers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblUsers");
        }
    }
}
