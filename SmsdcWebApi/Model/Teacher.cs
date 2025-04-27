using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsdcWebApi.Model
{
    public class Teacher : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? Qualification { get; set; }
        public string? CellPhone { get; set; }
        public string? AlternateNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? IdentityType { get; set; }
        public string? IdentityNumber { get; set; }
    }
}
