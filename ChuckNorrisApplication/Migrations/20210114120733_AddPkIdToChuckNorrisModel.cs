using Microsoft.EntityFrameworkCore.Migrations;

namespace ChuckNorrisApplication.Migrations
{
    public partial class AddPkIdToChuckNorrisModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChuckNorris",
                table: "ChuckNorris");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ChuckNorris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PkId",
                table: "ChuckNorris",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChuckNorris",
                table: "ChuckNorris",
                column: "PkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChuckNorris",
                table: "ChuckNorris");

            migrationBuilder.DropColumn(
                name: "PkId",
                table: "ChuckNorris");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ChuckNorris",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChuckNorris",
                table: "ChuckNorris",
                column: "Id");
        }
    }
}
