using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamProject.DataAccesss.Migrations
{
    public partial class UpdateMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostTime",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 0, 30, 53, 700, DateTimeKind.Local).AddTicks(3382),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 1, 14, 51, 12, 194, DateTimeKind.Local).AddTicks(9784));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostTime",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 1, 14, 51, 12, 194, DateTimeKind.Local).AddTicks(9784),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 3, 0, 30, 53, 700, DateTimeKind.Local).AddTicks(3382));
        }
    }
}
