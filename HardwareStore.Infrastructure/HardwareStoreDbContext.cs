namespace HardwareStore.Infrastructure
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class HardwareStoreDbContext : IdentityDbContext<Customer, IdentityRole<Guid>, Guid>
    {
        public HardwareStoreDbContext(DbContextOptions<HardwareStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;

        public DbSet<CharacteristicName> CharacteristicsNames { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(HardwareStoreDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}