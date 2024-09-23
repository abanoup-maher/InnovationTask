using Microsoft.EntityFrameworkCore.Migrations;

namespace InnovationTask.DAL.Context.Migrations
{
    public partial class Addsubj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subjects_students_StudentId1",
                table: "subjects");

            migrationBuilder.DropIndex(
                name: "IX_subjects_StudentId1",
                table: "subjects");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "subjects");

            migrationBuilder.AddColumn<string>(
                name: "SelectedSubjectIds",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedSubjectIds",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "subjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_subjects_StudentId1",
                table: "subjects",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_subjects_students_StudentId1",
                table: "subjects",
                column: "StudentId1",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
