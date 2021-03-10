using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductAPI.DAL.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BOD", "Country", "Name" },
                values: new object[] { 1, new DateTime(1981, 3, 10, 8, 8, 0, 256, DateTimeKind.Local).AddTicks(6760), "Iraq", "Author 1" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BOD", "Country", "Name" },
                values: new object[] { 2, new DateTime(1971, 3, 10, 8, 8, 0, 257, DateTimeKind.Local).AddTicks(9540), "United States", "Author 2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "IssueDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Book 1 description", new DateTime(2021, 3, 9, 8, 8, 0, 260, DateTimeKind.Local).AddTicks(8722), "Author 1 : Book 1" },
                    { 2, 1, "Book 2 description", new DateTime(2021, 3, 9, 8, 8, 0, 261, DateTimeKind.Local).AddTicks(43), "Author 1 : Book 2" },
                    { 3, 2, "Book 1 description", new DateTime(2021, 3, 9, 8, 8, 0, 261, DateTimeKind.Local).AddTicks(73), "Author 2 : Book 1" },
                    { 4, 2, "Book 2 description", new DateTime(2021, 3, 9, 8, 8, 0, 261, DateTimeKind.Local).AddTicks(77), "Author 2 : Book 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
