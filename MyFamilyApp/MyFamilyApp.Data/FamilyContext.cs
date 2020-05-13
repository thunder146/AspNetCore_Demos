using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MyFamilyApp.Data
{
    public class FamilyContext : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(
            builder => { builder.AddConsole(); });

        public DbSet<Family> Families { get; set; }

        public DbSet<Person> People { get; set; }

        public FamilyContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .EnableSensitiveDataLogging(true)
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=families;Trusted_Connection=True;");
        }
    }
}