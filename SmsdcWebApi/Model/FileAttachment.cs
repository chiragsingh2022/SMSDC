using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsdcWebApi.Model
{
    public class FileAttachment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Category { get; set; }

        public string DocumentPath { get; set; }

        public byte[] DocumentData { get; set; }

        public string DocumentName { get; set; }

        public string FileType { get; set; }

        public string ContentType { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset? Deleted { get; set; }

        public string DeletedBy { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        public Guid StudentId { get; set; }

        public DateTimeOffset? Modified { get; set; }

        public string ModifiedBy { get; set; }

        public string ProductCategory { get; set; }

    }
}
