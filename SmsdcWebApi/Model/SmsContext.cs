using Microsoft.EntityFrameworkCore;

namespace SmsdcWebApi.Model
{
    public class SmsContext : DbContext
    {
        public SmsContext() { }
        public SmsContext(DbContextOptions<SmsContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<FileAttachment> FileAttachments { get; set; }
        public DbSet<ListClass> ListClasses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=95.217.196.125;Database=SampleDatabase;user id=sa;password=Dup(e)0@98!;TrustServerCertificate=true;");
                //optionsBuilder.UseSqlServer("Server=localhost;Database=SMSDC;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
