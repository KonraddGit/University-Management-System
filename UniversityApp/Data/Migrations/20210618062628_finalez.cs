using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApp.Data.Migrations
{
    public partial class finalez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "SignedToDepartment",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SignedToDepartment",
                table: "AspNetUsers");

        }
    }
}
