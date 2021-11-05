using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApp.Data.Migrations
{
    public partial class departmentname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "DbCourse",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "DbCourse");
        }
    }
}
