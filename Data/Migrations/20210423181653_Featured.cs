using Microsoft.EntityFrameworkCore.Migrations;

namespace Songs_Manager.Data.Migrations
{
    public partial class Featured : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Featured",
                table: "Songs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Featured",
                table: "Songs",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
