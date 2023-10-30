using HSCOP.Provider.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HSCOP.Provider.DataAccess
{
    public class ProviderDbContext : DbContext
    {
        public ProviderDbContext(DbContextOptions<ProviderDbContext> options) : base(options)
        {
        }

        public DbSet<ProviderType> ProviderType { get; set; }
        public DbSet<ProviderComposition> ProviderComposition { get; set; }
        public DbSet<ProviderNode> ProviderNode { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}