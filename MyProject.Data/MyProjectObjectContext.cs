using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MyProject.Data
{
    /// <summary>
    /// MyProject Object context.
    /// </summary>
    public class MyProjectObjectContext : DbContext
    {
        public MyProjectObjectContext() : this(GetMySQLContextOptions()) { }

        public MyProjectObjectContext(DbContextOptions<MyProjectObjectContext> options) : base(options) { }

        public static MyProjectObjectContext Create() => new MyProjectObjectContext(GetMySQLContextOptions());

        public static DbContextOptionsBuilder<MyProjectObjectContext> GetDbContextOptionsBuilder()
        {
            var builder = new DbContextOptionsBuilder<MyProjectObjectContext>();
            builder.UseLazyLoadingProxies();
            return builder;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// Gets the MySQL context options.
        /// </summary>
        /// <returns>MySQL context options.</returns>
        private static DbContextOptions<MyProjectObjectContext> GetMySQLContextOptions()
        {
            var builder = GetDbContextOptionsBuilder()
                .UseMySql("Database=cyclr2;DataSource=localhost;Uid=cyclr;Password=cyclr;AllowUserVariables=true;Pooling=true;Convert Zero Datetime=true;", new MySqlServerVersion(new Version(major: 5, minor: 7, build: 37)));

            return builder.Options;
        }
    }
}
