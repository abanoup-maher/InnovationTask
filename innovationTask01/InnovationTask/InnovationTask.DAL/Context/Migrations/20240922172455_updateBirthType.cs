using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnovationTask.DAL.Context.Migrations
{
    public partial class updateBirthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date_of_birth",
                table: "students");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dateofbirth",
                table: "students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dateofbirth",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "Date_of_birth",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
