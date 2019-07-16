using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace DataAccessPostgreSqlProvider
{
    public class DomainModelPostgreSqlContext : DbContext
    {
        public DomainModelPostgreSqlContext(DbContextOptions<DomainModelPostgreSqlContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                builder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name.ToUpper());
            }

            base.OnModelCreating(builder);
        }
    }
}