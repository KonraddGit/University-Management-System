using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApp.Data.Migrations
{
    public partial class newmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateTime",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "UserAddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserBalanceId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DbRoom",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    RoomCapacity = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbRoom", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "DbUserAddress",
                columns: table => new
                {
                    UserAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartamentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbUserAddress", x => x.UserAddressId);
                });

            migrationBuilder.CreateTable(
                name: "DbUserBalance",
                columns: table => new
                {
                    UserBalanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    ECTS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbUserBalance", x => x.UserBalanceId);
                });

            migrationBuilder.CreateTable(
                name: "DbDepartment",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeRoomRoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbDepartment", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_DbDepartment_DbRoom_OfficeRoomRoomId",
                        column: x => x.OfficeRoomRoomId,
                        principalTable: "DbRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DbCourse",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbCourse", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_DbCourse_DbDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "DbDepartment",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DbSubject",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSubject", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_DbSubject_DbCourse_CourseId",
                        column: x => x.CourseId,
                        principalTable: "DbCourse",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DbSubject_DbRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "DbRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DbUserTakes",
                columns: table => new
                {
                    UserTakesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbUserTakes", x => x.UserTakesId);
                    table.ForeignKey(
                        name: "FK_DbUserTakes_DbCourse_CourseId",
                        column: x => x.CourseId,
                        principalTable: "DbCourse",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DbUserTeaches",
                columns: table => new
                {
                    UserTeachesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbUserTeaches", x => x.UserTeachesId);
                    table.ForeignKey(
                        name: "FK_DbUserTeaches_DbCourse_CourseId",
                        column: x => x.CourseId,
                        principalTable: "DbCourse",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DbTimeSlot",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbTimeSlot", x => x.TimeSlotId);
                    table.ForeignKey(
                        name: "FK_DbTimeSlot_DbSubject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "DbSubject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DaysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    TimeSlotId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DaysId);
                    table.ForeignKey(
                        name: "FK_Days_DbTimeSlot_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "DbTimeSlot",
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserAddressId",
                table: "AspNetUsers",
                column: "UserAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserBalanceId",
                table: "AspNetUsers",
                column: "UserBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_TimeSlotId",
                table: "Days",
                column: "TimeSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_DbCourse_DepartmentId",
                table: "DbCourse",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DbDepartment_OfficeRoomRoomId",
                table: "DbDepartment",
                column: "OfficeRoomRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_DbSubject_CourseId",
                table: "DbSubject",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DbSubject_RoomId",
                table: "DbSubject",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_DbTimeSlot_SubjectId",
                table: "DbTimeSlot",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_DbUserTakes_CourseId",
                table: "DbUserTakes",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DbUserTeaches_CourseId",
                table: "DbUserTeaches",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DbUserAddress_UserAddressId",
                table: "AspNetUsers",
                column: "UserAddressId",
                principalTable: "DbUserAddress",
                principalColumn: "UserAddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DbUserBalance_UserBalanceId",
                table: "AspNetUsers",
                column: "UserBalanceId",
                principalTable: "DbUserBalance",
                principalColumn: "UserBalanceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DbUserAddress_UserAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DbUserBalance_UserBalanceId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "DbUserAddress");

            migrationBuilder.DropTable(
                name: "DbUserBalance");

            migrationBuilder.DropTable(
                name: "DbUserTakes");

            migrationBuilder.DropTable(
                name: "DbUserTeaches");

            migrationBuilder.DropTable(
                name: "DbTimeSlot");

            migrationBuilder.DropTable(
                name: "DbSubject");

            migrationBuilder.DropTable(
                name: "DbCourse");

            migrationBuilder.DropTable(
                name: "DbDepartment");

            migrationBuilder.DropTable(
                name: "DbRoom");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserBalanceId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserBalanceId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");
        }
    }
}
