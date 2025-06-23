using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tablApi.Migrations
{
    /// <inheritdoc />
    public partial class Redoclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 81, 1 });

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
                keyValues: new object[] { 134, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 135, 2 });

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 135);

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 1, 2, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 1, 9, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 1, 16, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2024, 1, 23, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2024, 1, 30, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2024, 2, 6, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2024, 2, 13, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2024, 2, 20, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2024, 2, 27, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2024, 3, 5, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2024, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2024, 3, 19, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2024, 3, 26, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 41,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 4, new DateTime(2024, 1, 4, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2024, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2024, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2024, 1, 25, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2024, 2, 1, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2024, 2, 8, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2024, 2, 15, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2024, 2, 22, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2024, 2, 29, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2024, 3, 7, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2024, 3, 14, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2024, 3, 21, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2024, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 54,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 5, new DateTime(2024, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2024, 1, 8, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2024, 1, 15, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2024, 1, 22, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2024, 1, 29, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2024, 2, 5, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2024, 2, 12, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2024, 2, 19, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2024, 2, 26, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2024, 3, 4, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2024, 3, 11, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2024, 3, 18, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2024, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2024, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 68,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 6, new DateTime(2024, 1, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2024, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2024, 1, 17, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2024, 1, 24, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2024, 1, 31, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2024, 2, 7, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2024, 2, 14, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2024, 2, 21, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2024, 2, 28, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2024, 3, 6, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2024, 3, 13, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2024, 3, 20, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2024, 3, 27, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 81,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 7, new DateTime(2024, 1, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2024, 1, 9, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2024, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2024, 1, 23, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2024, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2024, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2024, 2, 13, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2024, 2, 20, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2024, 2, 27, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2024, 3, 5, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2024, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2024, 3, 19, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2024, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 94,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 8, new DateTime(2024, 1, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 95,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 8, new DateTime(2024, 1, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2024, 1, 18, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2024, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2024, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2024, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2024, 2, 15, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2024, 2, 22, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2024, 2, 29, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2024, 3, 7, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2024, 3, 14, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2024, 3, 21, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2024, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 107,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 9, new DateTime(2024, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 108,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 9, new DateTime(2024, 1, 8, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2024, 1, 15, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2024, 1, 22, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2024, 1, 29, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2024, 2, 5, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2024, 2, 12, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2024, 2, 19, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2024, 2, 26, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2024, 3, 4, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2024, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2024, 3, 18, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2024, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2024, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 121,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 10, new DateTime(2024, 1, 3, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 122,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 10, new DateTime(2024, 1, 10, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2024, 1, 17, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2024, 1, 24, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2024, 1, 31, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2024, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2024, 2, 14, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2024, 2, 21, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2024, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2024, 3, 6, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2024, 3, 20, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2024, 3, 27, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 1,
                column: "EndTime",
                value: new TimeSpan(0, 11, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 2,
                column: "EndTime",
                value: new TimeSpan(0, 11, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 3,
                columns: new[] { "DayOfWeek", "EndTime", "StartTime" },
                values: new object[] { 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 4,
                columns: new[] { "DayOfWeek", "EndTime", "StartTime" },
                values: new object[] { 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 7,
                columns: new[] { "DayOfWeek", "EndTime" },
                values: new object[] { 2, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 8,
                columns: new[] { "DayOfWeek", "EndTime" },
                values: new object[] { 4, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "StudentClassEntries",
                columns: new[] { "ClassEntry_ID", "Student_ID" },
                values: new object[,]
                {
                    { 107, 1 },
                    { 108, 1 },
                    { 54, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 107, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 108, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClassEntries",
                keyColumns: new[] { "ClassEntry_ID", "Student_ID" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 1, 8, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2024, 1, 22, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2024, 1, 29, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2024, 2, 5, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2024, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2024, 2, 19, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2024, 2, 26, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2024, 3, 4, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2024, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2024, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2024, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 41,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 3, new DateTime(2024, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2024, 1, 3, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2024, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2024, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2024, 1, 24, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2024, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2024, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2024, 2, 14, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2024, 2, 21, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2024, 2, 28, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2024, 3, 6, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2024, 3, 13, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2024, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 54,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 4, new DateTime(2024, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2024, 1, 8, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2024, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2024, 1, 22, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2024, 1, 29, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2024, 2, 5, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2024, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2024, 2, 19, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2024, 2, 26, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2024, 3, 4, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2024, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2024, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2024, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 68,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 5, new DateTime(2024, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2024, 1, 3, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2024, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2024, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2024, 1, 24, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2024, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2024, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2024, 2, 14, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2024, 2, 21, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2024, 2, 28, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2024, 3, 6, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2024, 3, 13, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2024, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 81,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 6, new DateTime(2024, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2024, 1, 8, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2024, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2024, 1, 22, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2024, 1, 29, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2024, 2, 5, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2024, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2024, 2, 19, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2024, 2, 26, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2024, 3, 4, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2024, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2024, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 94,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 7, new DateTime(2024, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 95,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 7, new DateTime(2024, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2024, 1, 3, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2024, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2024, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2024, 1, 24, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2024, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2024, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2024, 2, 14, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2024, 2, 21, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2024, 2, 28, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2024, 3, 6, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2024, 3, 13, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 107,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 8, new DateTime(2024, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 108,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 8, new DateTime(2024, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2024, 1, 8, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2024, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2024, 1, 22, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2024, 1, 29, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2024, 2, 5, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2024, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2024, 2, 19, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2024, 2, 26, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2024, 3, 4, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2024, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2024, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 121,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 9, new DateTime(2024, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 122,
                columns: new[] { "ClassSchedule_ID", "Date" },
                values: new object[] { 9, new DateTime(2024, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2024, 1, 3, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2024, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2024, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2024, 1, 24, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2024, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2024, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2024, 2, 14, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2024, 2, 21, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2024, 2, 28, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2024, 3, 6, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassEntries",
                keyColumn: "ClassEntry_ID",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2024, 3, 13, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ClassEntries",
                columns: new[] { "ClassEntry_ID", "ClassSchedule_ID", "Date" },
                values: new object[,]
                {
                    { 134, 10, new DateTime(2024, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, 10, new DateTime(2024, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 1,
                column: "EndTime",
                value: new TimeSpan(0, 10, 30, 0, 0));

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 2,
                column: "EndTime",
                value: new TimeSpan(0, 10, 30, 0, 0));

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

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 7,
                columns: new[] { "DayOfWeek", "EndTime" },
                values: new object[] { 1, new TimeSpan(0, 10, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 8,
                columns: new[] { "DayOfWeek", "EndTime" },
                values: new object[] { 3, new TimeSpan(0, 10, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Schedule_ID",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "StudentClassEntries",
                columns: new[] { "ClassEntry_ID", "Student_ID" },
                values: new object[,]
                {
                    { 81, 1 },
                    { 134, 1 },
                    { 135, 1 },
                    { 134, 2 },
                    { 135, 2 }
                });
        }
    }
}
