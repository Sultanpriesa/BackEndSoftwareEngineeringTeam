using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tablApi.Migrations
{
    /// <inheritdoc />
    public partial class v1Update : Migration
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
                    student_yearLevel = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Class_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class_Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class_yearLevel = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "ClassSchedules",
                columns: table => new
                {
                    Schedule_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_ID = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "StudentClasses",
                columns: table => new
                {
                    EnrolledClassesClass_ID = table.Column<int>(type: "int", nullable: false),
                    EnrolledStudentsStudent_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClasses", x => new { x.EnrolledClassesClass_ID, x.EnrolledStudentsStudent_ID });
                    table.ForeignKey(
                        name: "FK_StudentClasses_Classes_EnrolledClassesClass_ID",
                        column: x => x.EnrolledClassesClass_ID,
                        principalTable: "Classes",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClasses_Students_EnrolledStudentsStudent_ID",
                        column: x => x.EnrolledStudentsStudent_ID,
                        principalTable: "Students",
                        principalColumn: "Student_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassEntries",
                columns: table => new
                {
                    ClassEntry_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_ID = table.Column<int>(type: "int", nullable: false),
                    ClassSchedule_ID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassEntries", x => x.ClassEntry_ID);
                    table.ForeignKey(
                        name: "FK_ClassEntries_ClassSchedules_ClassSchedule_ID",
                        column: x => x.ClassSchedule_ID,
                        principalTable: "ClassSchedules",
                        principalColumn: "Schedule_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassEntries_Classes_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Classes",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassEntryStudents",
                columns: table => new
                {
                    ClassEntriesClassEntry_ID = table.Column<int>(type: "int", nullable: false),
                    StudentsStudent_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassEntryStudents", x => new { x.ClassEntriesClassEntry_ID, x.StudentsStudent_ID });
                    table.ForeignKey(
                        name: "FK_ClassEntryStudents_ClassEntries_ClassEntriesClassEntry_ID",
                        column: x => x.ClassEntriesClassEntry_ID,
                        principalTable: "ClassEntries",
                        principalColumn: "ClassEntry_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassEntryStudents_Students_StudentsStudent_ID",
                        column: x => x.StudentsStudent_ID,
                        principalTable: "Students",
                        principalColumn: "Student_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_ID", "User_email", "User_password", "User_type" },
                values: new object[,]
                {
                    { 1, "admin@school.com", "admin123", "Admin" },
                    { 2, "john.doe@school.com", "hashed_password_2", "Tutor" },
                    { 3, "jane.smith@school.com", "hashed_password_3", "Tutor" },
                    { 4, "alice@student.com", "hashed_password_4", "Student" },
                    { 5, "bob@student.com", "hashed_password_5", "Student" },
                    { 6, "charlie@student.com", "hashed_password_6", "Student" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Student_ID", "Student_LastName", "Student_firstName", "User_ID", "student_yearLevel" },
                values: new object[,]
                {
                    { 1, "Johnson", "Alice", 4, 1 },
                    { 2, "Williams", "Bob", 5, 2 },
                    { 3, "Brown", "Charlie", 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Tutor_ID", "Tutor_LastName", "Tutor_firstName", "User_ID" },
                values: new object[,]
                {
                    { 1, "Doe", "John", 2 },
                    { 2, "Smith", "Jane", 3 }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Class_ID", "Class_Desc", "Class_Name", "Class_yearLevel", "EndDate", "StartDate", "Tutor_ID" },
                values: new object[,]
                {
                    { 1, "Advanced mathematics class covering calculus and linear algebra", "Mathematics", 1, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Introduction to physics covering mechanics and thermodynamics", "Physics", 1, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Programming fundamentals and data structures", "Computer Science", 1, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ClassSchedules",
                columns: new[] { "Schedule_ID", "Class_ID", "DayOfWeek", "EndTime", "Room", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeSpan(0, 11, 0, 0, 0), "Room 101", new TimeSpan(0, 9, 0, 0, 0) },
                    { 2, 1, 3, new TimeSpan(0, 11, 0, 0, 0), "Room 101", new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 1, 5, new TimeSpan(0, 11, 0, 0, 0), "Room 101", new TimeSpan(0, 9, 0, 0, 0) },
                    { 4, 2, 1, new TimeSpan(0, 15, 0, 0, 0), "Room 102", new TimeSpan(0, 13, 0, 0, 0) },
                    { 5, 2, 3, new TimeSpan(0, 15, 0, 0, 0), "Room 102", new TimeSpan(0, 13, 0, 0, 0) },
                    { 6, 2, 5, new TimeSpan(0, 15, 0, 0, 0), "Room 102", new TimeSpan(0, 13, 0, 0, 0) },
                    { 7, 3, 2, new TimeSpan(0, 11, 0, 0, 0), "Room 103", new TimeSpan(0, 9, 0, 0, 0) },
                    { 8, 3, 4, new TimeSpan(0, 11, 0, 0, 0), "Room 103", new TimeSpan(0, 9, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassEntries_Class_ID",
                table: "ClassEntries",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassEntries_ClassSchedule_ID",
                table: "ClassEntries",
                column: "ClassSchedule_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassEntryStudents_StudentsStudent_ID",
                table: "ClassEntryStudents",
                column: "StudentsStudent_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Tutor_ID",
                table: "Classes",
                column: "Tutor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_Class_ID",
                table: "ClassSchedules",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_EnrolledStudentsStudent_ID",
                table: "StudentClasses",
                column: "EnrolledStudentsStudent_ID");

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
                name: "ClassEntryStudents");

            migrationBuilder.DropTable(
                name: "StudentClasses");

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
