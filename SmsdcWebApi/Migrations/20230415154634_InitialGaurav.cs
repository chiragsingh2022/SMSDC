using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmsdcWebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialGaurav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaStudents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RollNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    HighSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolRollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolPassDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HighSchoolSubject1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject1Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject2Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject3Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject4Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject5Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject6Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject7Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolTotalPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateRollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediatePassDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IntermediateSubject1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject1Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject2Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject3Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject4Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject5Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject6Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject7Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateTotalPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationCollegeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationCourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationPassYear = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BscStudents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RollNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    HighSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolRollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolPassDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HighSchoolSubject1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject1Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject2Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject3Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject4Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject5Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject6Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolSubject7Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolTotalPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateRollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediatePassDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IntermediateSubject1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject1Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject2Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject3Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject4Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject5Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject6Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSubject7Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateTotalPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationCollegeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationCourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationPassYear = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BscStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaStudents");

            migrationBuilder.DropTable(
                name: "BscStudents");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
