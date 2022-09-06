using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Solution.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 48, 4, 125, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 48, 4, 125, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 48, 4, 125, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 48, 4, 125, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 48, 4, 125, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 48, 4, 125, DateTimeKind.Local).AddTicks(3559));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 47, 37, 765, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(635));
        }
    }
}
