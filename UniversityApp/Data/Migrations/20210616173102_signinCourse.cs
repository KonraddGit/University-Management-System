using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApp.Data.Migrations
{
    public partial class signinCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SignInAvailable",
                table: "DbDepartment",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
