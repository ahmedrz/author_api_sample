using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductAPI.DAL.Migrations
{
    public partial class validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Authors",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "BOD",
                value: new DateTime(1981, 3, 10, 11, 58, 2, 291, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "BOD",
                value: new DateTime(1971, 3, 10, 11, 58, 2, 292, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "IssueDate",
                value: new DateTime(2021, 3, 9, 11, 58, 2, 296, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "IssueDate",
                value: new DateTime(2021, 3, 9, 11, 58, 2, 296, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "IssueDate",
                value: new DateTime(2021, 3, 9, 11, 58, 2, 296, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "IssueDate",
                value: new DateTime(2021, 3, 9, 11, 58, 2, 296, DateTimeKind.Local).AddTicks(1329));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "BOD",
                value: new DateTime(1981, 3, 10, 8, 8, 0, 256, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "BOD",
                value: new DateTime(1971, 3, 10, 8, 8, 0, 257, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "IssueDate",
                value: new DateTime(2021, 3, 9, 8, 8, 0, 260, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "IssueDate",
                value: new DateTime(2021, 3, 9, 8, 8, 0, 261, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "IssueDate",
                value: new DateTime(2021, 3, 9, 8, 8, 0, 261, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "IssueDate",
                value: new DateTime(2021, 3, 9, 8, 8, 0, 261, DateTimeKind.Local).AddTicks(77));
        }
    }
}
