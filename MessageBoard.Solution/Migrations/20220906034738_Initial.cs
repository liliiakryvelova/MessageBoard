using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Home" },
                    { 2, "Work" },
                    { 3, "Before work" },
                    { 4, "After work" },
                    { 5, "Before school" },
                    { 6, "After school" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "CategoryId", "Date", "Description" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(635), "Prepare the dinner" },
                    { 3, 2, new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(628), "Clean the room" },
                    { 5, 2, new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(633), "Wash the dishes" },
                    { 1, 3, new DateTime(2022, 9, 5, 20, 47, 37, 765, DateTimeKind.Local).AddTicks(9841), "Go for a walk outside" },
                    { 2, 3, new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(617), "Walk with dog" },
                    { 4, 4, new DateTime(2022, 9, 5, 20, 47, 37, 766, DateTimeKind.Local).AddTicks(631), "Read the book" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CategoryId",
                table: "Messages",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
