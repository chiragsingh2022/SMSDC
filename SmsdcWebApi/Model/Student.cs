namespace SmsdcWebApi.Model
{
    public class Student : BaseClass
    {
        public Guid Id { get; set; }
        public string? Session { get; set; }
        public string? Batch { get; set; }
        public DateTimeOffset? AdmissionDate { get; set; }
        public string? RollNumber { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public DateTimeOffset? DOB { get; set; }
        public string? Age { get; set; }
        public string? Mobile { get; set; }
        public string? AdhaarNumber { get; set; }
        public string? Cast { get; set; }
        public string? SubCast { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Semester { get; set; }

        #region FamilyDetail

        public string? FatherFirstName { get; set; }
        public string? FatherMiddleName { get; set; }
        public string? FatherLastName { get; set; }
        public string? FatherOccupation { get; set; }
        public string? FatherIncome { get; set; }
        public string? FatherMobile { get; set; }
        public string? FatherEmail { get; set; }
        public string? MotherFirstName { get; set; }
        public string? MotherMiddleName { get; set; }
        public string? MotherLastName { get; set; }
        public string? MotherOccupation { get; set; }
        public string? MotherIncome { get; set; }
        public string? MotherMobile { get; set; }
        public string? MotherEmail { get; set; }
        #endregion

        #region EducationalDetail

        public string? Subject1 { get; set; }
        public string? Subject2 { get; set; }
        public string? Subject3 { get; set; }
        public string? Subject4 { get; set; }
        public string? Subject5 { get; set; }
        public string? Subject6 { get; set; }
        public string? Subject7 { get; set; }
        public string? Subject8 { get; set; }
        public string? ClassStatus { get; set; }
        public bool? IsBackPaper { get; set; }
        public bool? IsEx { get; set; }

        //10th Details
        public string? HighSchoolName { get; set; }
        public string? HighSchoolRollNumber { get; set; }
        public DateTimeOffset? HighSchoolPassDate { get; set; }
        public string? HighSchoolSubjects { get; set; }
        public string? HighSchoolTotalMarks { get; set; }
        public string? HighSchoolObtainedMarks { get; set; }
        public decimal? HighSchoolPercentage { get; set; }

        //12th Details
        public string? IntermediateSchoolName { get; set; }
        public string? IntermediateRollNumber { get; set; }
        public DateTimeOffset? IntermediatePassDate { get; set; }
        public string? IntermediateSubjects { get; set; }
        public string? IntermediateTotalMarks { get; set; }
        public string? IntermediateObtainedMarks { get; set; }
        public decimal? IntermediatePercentage { get; set; }

        //Graduation Details
        public string? GraduationSchoolName { get; set; }
        public string? GraduationRollNumber { get; set; }
        public DateTimeOffset? GraduationPassDate { get; set; }
        public string? GraduationSubjects { get; set; }
        public string? GraduationTotalMarks { get; set; }
        public string? GraduationObtainedMarks { get; set; }
        public decimal? GraduationPercentage { get; set; }
        #endregion
    }
}
