using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmsdcWebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialChirag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GraduationPassYear",
                table: "BaStudents");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "BscStudents",
                newName: "Subject5");

            migrationBuilder.RenameColumn(
                name: "GraduationStatus",
                table: "BaStudents",
                newName: "Subject5");

            migrationBuilder.RenameColumn(
                name: "GraduationCourseName",
                table: "BaStudents",
                newName: "Subject4");

            migrationBuilder.RenameColumn(
                name: "GraduationCollegeName",
                table: "BaStudents",
                newName: "Subject3");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "BaStudents",
                newName: "Subject2");

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "BscStudents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject1",
                table: "BscStudents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject2",
                table: "BscStudents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject3",
                table: "BscStudents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject4",
                table: "BscStudents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "BaStudents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject1",
                table: "BaStudents",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semester",
                table: "BscStudents");

            migrationBuilder.DropColumn(
                name: "Subject1",
                table: "BscStudents");

            migrationBuilder.DropColumn(
                name: "Subject2",
                table: "BscStudents");

            migrationBuilder.DropColumn(
                name: "Subject3",
                table: "BscStudents");

            migrationBuilder.DropColumn(
                name: "Subject4",
                table: "BscStudents");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "BaStudents");

            migrationBuilder.DropColumn(
                name: "Subject1",
                table: "BaStudents");

            migrationBuilder.RenameColumn(
                name: "Subject5",
                table: "BscStudents",
                newName: "Class");

            migrationBuilder.RenameColumn(
                name: "Subject5",
                table: "BaStudents",
                newName: "GraduationStatus");

            migrationBuilder.RenameColumn(
                name: "Subject4",
                table: "BaStudents",
                newName: "GraduationCourseName");

            migrationBuilder.RenameColumn(
                name: "Subject3",
                table: "BaStudents",
                newName: "GraduationCollegeName");

            migrationBuilder.RenameColumn(
                name: "Subject2",
                table: "BaStudents",
                newName: "Class");

            migrationBuilder.AddColumn<DateTime>(
                name: "GraduationPassYear",
                table: "BaStudents",
                type: "datetime2",
                nullable: true);
        }
    }
}
