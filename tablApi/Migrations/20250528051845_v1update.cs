using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tablApi.Migrations
{
    /// <inheritdoc />
    public partial class v1update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_ID);
                    table.ForeignKey(
                        name: "FK_Students_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tutors",
                columns: table => new
                {
                    Tutor_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tutor_firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tutor_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutors", x => x.Tutor_ID);
                    table.ForeignKey(
                        name: "FK_Tutors_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Class_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class_Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tutor_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Class_ID);
                    table.ForeignKey(
                        name: "FK_Classes_Tutors_Tutor_ID",
                        column: x => x.Tutor_ID,
                        principalTable: "Tutors",
                        principalColumn: "Tutor_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassLists",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    Class_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLists", x => new { x.Student_ID, x.Class_ID });
                    table.ForeignKey(
                        name: "FK_ClassLists_Classes_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Classes",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassLists_Students_Student_ID",
                        column: x => x.Student_ID,
                        principalTable: "Students",
                        principalColumn: "Student_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSchedules",
                columns: table => new
                {
                    Schedule_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Class_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSchedules", x => x.Schedule_ID);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Classes_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Classes",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassEntries",
                columns: table => new
                {
                    ClassEntry_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassSchedule_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassEntries", x => x.ClassEntry_ID);
                    table.ForeignKey(
                        name: "FK_ClassEntries_ClassSchedules_ClassSchedule_ID",
                        column: x => x.ClassSchedule_ID,
                        principalTable: "ClassSchedules",
                        principalColumn: "Schedule_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentClassEntries",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    ClassEntry_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClassEntries", x => new { x.Student_ID, x.ClassEntry_ID });
                    table.ForeignKey(
                        name: "FK_StudentClassEntries_ClassEntries_ClassEntry_ID",
                        column: x => x.ClassEntry_ID,
                        principalTable: "ClassEntries",
                        principalColumn: "ClassEntry_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClassEntries_Students_Student_ID",
                        column: x => x.Student_ID,
                        principalTable: "Students",
                        principalColumn: "Student_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_ID", "User_email", "User_password", "User_type" },
                values: new object[,]
                {
                    { 1, "admin", "admin", "Admin" },
                    { 2, "john.tutor@school.com", "tutor123", "Tutor" },
                    { 3, "jane.tutor@school.com", "tutor123", "Tutor" },
                    { 4, "alice.student@school.com", "student123", "Student" },
                    { 5, "bob.student@school.com", "student123", "Student" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Student_ID", "Student_LastName", "Student_firstName", "User_ID" },
                values: new object[,]
                {
                    { 1, "Johnson", "Alice", 4 },
                    { 2, "Williams", "Bob", 5 }
                });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Tutor_ID", "Tutor_LastName", "Tutor_firstName", "User_ID" },
                values: new object[,]
                {
                    { 1, "Smith", "John", 2 },
                    { 2, "Doe", "Jane", 3 }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Class_ID", "Class_Desc", "Class_Name", "EndDate", "Room", "StartDate", "Tutor_ID" },
                values: new object[,]
                {
                    { 1, "Introduction to Basic Mathematics", "Mathematics 101", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 101", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Introduction to Physics", "Physics 101", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 102", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ClassLists",
                columns: new[] { "Class_ID", "Student_ID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "ClassSchedules",
                columns: new[] { "Schedule_ID", "Class_ID", "DayOfWeek", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 2, 1, 3, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 2, 2, new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 13, 0, 0, 0) },
                    { 4, 2, 4, new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 13, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "ClassEntries",
                columns: new[] { "ClassEntry_ID", "ClassSchedule_ID", "Date" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "StudentClassEntries",
                columns: new[] { "ClassEntry_ID", "Student_ID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassEntries_ClassSchedule_ID",
                table: "ClassEntries",
                column: "ClassSchedule_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Tutor_ID",
                table: "Classes",
                column: "Tutor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassLists_Class_ID",
                table: "ClassLists",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_Class_ID",
                table: "ClassSchedules",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassEntries_ClassEntry_ID",
                table: "StudentClassEntries",
                column: "ClassEntry_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_User_ID",
                table: "Students",
                column: "User_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tutors_User_ID",
                table: "Tutors",
                column: "User_ID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassLists");

            migrationBuilder.DropTable(
                name: "StudentClassEntries");

            migrationBuilder.DropTable(
                name: "ClassEntries");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassSchedules");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Tutors");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
