using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Company> Company { get; set; }
        public DbSet<FieldSpecialist> FieldSpecialists { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}
