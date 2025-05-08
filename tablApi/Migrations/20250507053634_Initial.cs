using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tablApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course_Desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Course_ID);
                });

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
                    Class_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class_yearLevel = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Tutor_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Class_ID);
                    table.ForeignKey(
                        name: "FK_Classes_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Tutors_Tutor_ID",
                        column: x => x.Tutor_ID,
                        principalTable: "Tutors",
                        principalColumn: "Tutor_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSchedules",
                columns: table => new
                {
                    Schedule_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_ID = table.Column<int>(type: "int", nullable: false),
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
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
                name: "Students",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_yearLevel = table.Column<int>(type: "int", nullable: true),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    ClassScheduleSchedule_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_ID);
                    table.ForeignKey(
                        name: "FK_Students_ClassSchedules_ClassScheduleSchedule_ID",
                        column: x => x.ClassScheduleSchedule_ID,
                        principalTable: "ClassSchedules",
                        principalColumn: "Schedule_ID");
                    table.ForeignKey(
                        name: "FK_Students_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Course_ID", "Course_Desc", "Course_Name" },
                values: new object[,]
                {
                    { 1, "Advanced mathematics course", "Mathematics" },
                    { 2, "Introduction to physics", "Physics" },
                    { 3, "Programming fundamentals", "Computer Science" },
                    { 4, "English literature and composition", "English" },
                    { 5, "World history overview", "History" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_ID", "User_email", "User_password", "User_type" },
                values: new object[,]
                {
                    { 1, "admin", "admin", "Admin" },
                    { 2, "jane.smith@email.com", "hashed_password_2", "Tutor" },
                    { 3, "alice@email.com", "hashed_password_3", "Student" },
                    { 4, "bob@email.com", "hashed_password_4", "Student" },
                    { 5, "charlie@email.com", "hashed_password_5", "Student" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Student_ID", "ClassScheduleSchedule_ID", "Student_LastName", "Student_firstName", "User_ID", "student_yearLevel" },
                values: new object[,]
                {
                    { 1, null, "Johnson", "Alice", 3, 1 },
                    { 2, null, "Williams", "Bob", 4, 2 },
                    { 3, null, "Brown", "Charlie", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Tutor_ID", "Tutor_LastName", "Tutor_firstName", "User_ID" },
                values: new object[,]
                {
                    { 1, "Doe", "John", 1 },
                    { 2, "Smith", "Jane", 2 }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Class_ID", "Class_desc", "Class_name", "Class_yearLevel", "Course_ID", "Tutor_ID" },
                values: new object[,]
                {
                    { 1, "Basic Mathematics", "Math 101", 1, 1, 1 },
                    { 2, "Introduction to Physics", "Physics 101", 1, 2, 1 },
                    { 3, "Introduction to Programming", "Programming 101", 1, 3, 2 },
                    { 4, "Basic English", "English 101", 1, 4, 2 },
                    { 5, "World History", "History 101", 1, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "ClassSchedules",
                columns: new[] { "Schedule_ID", "Class_ID", "Date", "Student_ID", "Time" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { 2, 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new TimeSpan(0, 11, 0, 0, 0) },
                    { 5, 4, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(0, 13, 0, 0, 0) },
                    { 6, 5, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new TimeSpan(0, 14, 0, 0, 0) },
                    { 7, 1, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { 8, 2, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(0, 10, 0, 0, 0) },
                    { 9, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(0, 11, 0, 0, 0) },
                    { 10, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new TimeSpan(0, 13, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Course_ID",
                table: "Classes",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Tutor_ID",
                table: "Classes",
                column: "Tutor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_Class_ID",
                table: "ClassSchedules",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_Student_ID",
                table: "ClassSchedules",
                column: "Student_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassScheduleSchedule_ID",
                table: "Students",
                column: "ClassScheduleSchedule_ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_Students_Student_ID",
                table: "ClassSchedules",
                column: "Student_ID",
                principalTable: "Students",
                principalColumn: "Student_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Courses_Course_ID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Tutors_Tutor_ID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_Classes_Class_ID",
                table: "ClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_Students_Student_ID",
                table: "ClassSchedules");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Tutors");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassSchedules");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
