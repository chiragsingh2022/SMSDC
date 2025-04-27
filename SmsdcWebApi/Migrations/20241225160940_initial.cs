using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmsdcWebApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Session = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdhaarNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBackPaper = table.Column<bool>(type: "bit", nullable: true),
                    IsEx = table.Column<bool>(type: "bit", nullable: true),
                    HighSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolRollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolPassDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    HighSchoolSubjects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolTotalMarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolObtainedMarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IntermediateSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateRollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediatePassDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IntermediateSubjects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateTotalMarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateObtainedMarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediatePercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GraduationSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationRollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationPassDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GraduationSubjects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationTotalMarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationObtainedMarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileAttachments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_StudentId",
                table: "FileAttachments",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileAttachments");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
