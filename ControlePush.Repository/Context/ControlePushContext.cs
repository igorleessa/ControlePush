using Microsoft.EntityFrameworkCore;

namespace ControlePush.Repository.Context
{
    public class ControlePushContext : DbContext
    {
        public ControlePushContext(DbContextOptions<ControlePushContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ControlePushContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
