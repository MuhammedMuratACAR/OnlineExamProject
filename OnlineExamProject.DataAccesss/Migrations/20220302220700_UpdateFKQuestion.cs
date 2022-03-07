using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamProject.DataAccesss.Migrations
{
    public partial class UpdateFKQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamCode",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "ExamCode",
                table: "Questions",
                newName: "ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_ExamCode",
                table: "Questions",
                newName: "IX_Questions_ExamId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostTime",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 1, 6, 59, 813, DateTimeKind.Local).AddTicks(8158),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 3, 0, 30, 53, 700, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "Questions",
                newName: "ExamCode");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                newName: "IX_Questions_ExamCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostTime",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 0, 30, 53, 700, DateTimeKind.Local).AddTicks(3382),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 3, 1, 6, 59, 813, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamCode",
                table: "Questions",
                column: "ExamCode",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
