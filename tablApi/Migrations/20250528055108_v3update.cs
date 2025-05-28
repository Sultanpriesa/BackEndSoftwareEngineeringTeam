using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tablApi.Migrations
{
    /// <inheritdoc />
    public partial class v3update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 2,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 1, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 3,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 1, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 4,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 1, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ClassEntries",
                columns: new[] { "ClassEntry_ID", "ClassSchedule_ID", "Date" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 2, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 2, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 2, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 2, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 2, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 2, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 3, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 3, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 3, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 3, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 3, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 3, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 3, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 4, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 4, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 4, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 4, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 4, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 4, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 4, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 4, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 3,
                columns: new[] { "DayOfWeek", "EndTime", "StartTime" },
                values: new object[] { 1, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 4,
                columns: new[] { "DayOfWeek", "EndTime", "StartTime" },
                values: new object[] { 3, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Class_ID", "Class_Desc", "Class_Name", "EndDate", "Room", "StartDate", "Tutor_ID" },
                values: new object[,]
                {
                    { 3, "Introduction to Chemistry", "Chemistry 101", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 103", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "Introduction to Biology", "Biology 101", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 104", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "Introduction to Programming", "Computer Science 101", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 105", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "StudentClassEntries",
                columns: new[] { "ClassEntry_ID", "Student_ID" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "ClassLists",
                columns: new[] { "Class_ID", "Student_ID" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 5, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "ClassSchedules",
                columns: new[] { "Schedule_ID", "Class_ID", "DayOfWeek", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 5, 3, 1, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 6, 3, 3, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 7, 4, 1, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 8, 4, 3, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 9, 5, 1, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 10, 5, 3, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "StudentClassEntries",
                columns: new[] { "ClassEntry_ID", "Student_ID" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 23, 1 },
                    { 24, 1 },
                    { 25, 1 },
                    { 26, 1 },
                    { 27, 1 },
                    { 28, 1 },
                    { 29, 1 },
                    { 30, 1 },
                    { 31, 1 },
                    { 32, 1 },
                    { 33, 1 },
                    { 34, 1 },
                    { 35, 1 },
                    { 36, 1 },
                    { 37, 1 },
                    { 38, 1 },
                    { 39, 1 },
                    { 40, 1 },
                    { 41, 1 },
                    { 42, 1 },
                    { 43, 1 },
                    { 44, 1 },
                    { 45, 1 },
                    { 46, 1 },
                    { 47, 1 },
                    { 48, 1 },
                    { 49, 1 },
                    { 50, 1 },
                    { 51, 1 },
                    { 52, 1 },
                    { 53, 1 },
                    { 54, 1 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 2 },
                    { 14, 2 },
                    { 15, 2 },
                    { 16, 2 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 21, 2 },
                    { 22, 2 },
                    { 23, 2 },
                    { 24, 2 },
                    { 25, 2 },
                    { 26, 2 },
                    { 27, 2 }
                });

            migrationBuilder.InsertData(
                table: "ClassEntries",
                columns: new[] { "ClassEntry_ID", "ClassSchedule_ID", "Date" },
                values: new object[,]
                {
                    { 55, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 5, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 5, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 5, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 5, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 5, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 5, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 5, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 5, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 5, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 5, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 5, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 6, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 6, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 6, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 6, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 6, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 6, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 6, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 6, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 6, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 6, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 6, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 6, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 7, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 7, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 7, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 7, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 7, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 7, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 7, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 7, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 7, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 7, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 7, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 7, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 7, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 8, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 8, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 8, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 8, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 8, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 8, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 8, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 8, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 8, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 8, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 8, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, 8, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, 9, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 9, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, 9, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 9, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, 9, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 9, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 9, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 9, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 9, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, 9, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 9, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 9, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 9, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 10, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 10, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, 10, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 10, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, 10, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 10, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 10, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, 10, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, 10, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, 10, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, 10, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, 10, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "StudentClassEntries",
                columns: new[] { "ClassEntry_ID", "Student_ID" },
                values: new object[,]
                {
                    { 55, 1 },
                    { 56, 1 },
                    { 57, 1 },
                    { 58, 1 },
                    { 59, 1 },
                    { 60, 1 },
                    { 61, 1 },
                    { 62, 1 },
                    { 63, 1 },
                    { 64, 1 },
                    { 65, 1 },
                    { 66, 1 },
                    { 67, 1 },
                    { 68, 1 },
                    { 69, 1 },
                    { 70, 1 },
                    { 71, 1 },
                    { 72, 1 },
                    { 73, 1 },
                    { 74, 1 },
                    { 75, 1 },
                    { 76, 1 },
                    { 77, 1 },
                    { 78, 1 },
                    { 79, 1 },
                    { 80, 1 },
                    { 81, 1 },
                    { 109, 1 },
                    { 110, 1 },
                    { 111, 1 },
                    { 112, 1 },
                    { 113, 1 },
                    { 114, 1 },
                    { 115, 1 },
                    { 116, 1 },
                    { 117, 1 },
                    { 118, 1 },
                    { 119, 1 },
                    { 120, 1 },
                    { 121, 1 },
                    { 122, 1 },
                    { 123, 1 },
                    { 124, 1 },
                    { 125, 1 },
                    { 126, 1 },
                    { 127, 1 },
                    { 128, 1 },
                    { 129, 1 },
                    { 130, 1 },
                    { 131, 1 },
                    { 132, 1 },
                    { 133, 1 },
                    { 134, 1 },
                    { 135, 1 },
                    { 55, 2 },
                    { 56, 2 },
                    { 57, 2 },
                    { 58, 2 },
                    { 59, 2 },
                    { 60, 2 },
                    { 61, 2 },
                    { 62, 2 },
                    { 63, 2 },
                    { 64, 2 },
                    { 65, 2 },
                    { 66, 2 },
                    { 67, 2 },
                    { 68, 2 },
                    { 69, 2 },
                    { 70, 2 },
                    { 71, 2 },
                    { 72, 2 },
                    { 73, 2 },
                    { 74, 2 },
                    { 75, 2 },
                    { 76, 2 },
                    { 77, 2 },
                    { 78, 2 },
                    { 79, 2 },
                    { 80, 2 },
                    { 81, 2 },
                    { 82, 2 },
                    { 83, 2 },
                    { 84, 2 },
                    { 85, 2 },
                    { 86, 2 },
                    { 87, 2 },
                    { 88, 2 },
                    { 89, 2 },
                    { 90, 2 },
                    { 91, 2 },
                    { 92, 2 },
                    { 93, 2 },
                    { 94, 2 },
                    { 95, 2 },
                    { 96, 2 },
                    { 97, 2 },
                    { 98, 2 },
                    { 99, 2 },
                    { 100, 2 },
                    { 101, 2 },
                    { 102, 2 },
                    { 103, 2 },
                    { 104, 2 },
                    { 105, 2 },
                    { 106, 2 },
                    { 107, 2 },
                    { 108, 2 },
                    { 109, 2 },
                    { 110, 2 },
                    { 111, 2 },
                    { 112, 2 },
                    { 113, 2 },
                    { 114, 2 },
                    { 115, 2 },
                    { 116, 2 },
                    { 117, 2 },
                    { 118, 2 },
                    { 119, 2 },
                    { 120, 2 },
                    { 121, 2 },
                    { 122, 2 },
                    { 123, 2 },
                    { 124, 2 },
                    { 125, 2 },
                    { 126, 2 },
                    { 127, 2 },
                    { 128, 2 },
                    { 129, 2 },
                    { 130, 2 },
                    { 131, 2 },
                    { 132, 2 },
                    { 133, 2 },
                    { 134, 2 },
                    { 135, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassLists",
                keyColumns: new[] { "Class_ID", "Student_ID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ClassLists",
                keyColumns: new[] { "Class_ID", "Student_ID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ClassLists",
                keyColumns: new[] { "Class_ID", "Student_ID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ClassLists",
                keyColumns: new[] { "Class_ID", "Student_ID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ClassLists",
                keyColumns: new[] { "Class_ID", "Student_ID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 109, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 110, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 111, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 112, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 113, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 114, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 115, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 116, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 117, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 118, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 119, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 120, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 121, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 122, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 123, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 124, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 125, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 126, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 127, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 128, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 129, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 130, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 131, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 132, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 133, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 134, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 135, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 55, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 57, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 58, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 59, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 62, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 63, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 64, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 65, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 66, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 68, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 74, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 91, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 93, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 94, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 99, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 101, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 102, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 103, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 104, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 105, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 106, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 107, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 108, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 109, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 110, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 111, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 112, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 113, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 114, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 115, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 116, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 117, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 118, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 119, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 120, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 121, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 122, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 123, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 124, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 125, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 126, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 127, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 128, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 129, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 130, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 131, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 132, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 133, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 134, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 135, 2 });

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Class_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Class_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Class_ID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 2,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 2, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 3,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 4,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 3,
                columns: new[] { "DayOfWeek", "EndTime", "StartTime" },
                values: new object[] { 2, new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 4,
                columns: new[] { "DayOfWeek", "EndTime", "StartTime" },
                values: new object[] { 4, new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 13, 0, 0, 0) });
        }
    }
}
