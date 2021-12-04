using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Data
{
    public class BloggerContext : DbContext
    {
        public BloggerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public override int SaveChanges()
        {

            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is AuditableEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((AuditableEntity)entityEntry.Entity).LastModified = System.DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    ((AuditableEntity)entityEntry.Entity).Created = System.DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }
    }
}
