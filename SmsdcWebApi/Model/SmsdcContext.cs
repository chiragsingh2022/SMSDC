using Microsoft.EntityFrameworkCore;

namespace SmsdcWebApi.Model
{
    public class SmsdcContext : DbContext
    {
        public SmsdcContext() { }
        public SmsdcContext(DbContextOptions<SmsdcContext> options) : base(options)
        {
        }
        public DbSet<Ba> BaStudents { get; set; }
        public DbSet<Bsc> BscStudents { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=95.217.196.125;Database=SampleDatabase;user id=sa;password=Dup(e)0@98!;TrustServerCertificate=true;");
                optionsBuilder.UseSqlServer("Server=localhost;Database=SMSDC;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
