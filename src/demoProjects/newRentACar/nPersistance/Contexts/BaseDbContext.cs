using nDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace nPersistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<SomeFeatureEntity> SomeFeatureEntities { get; set; }


        public BaseDbContext(DbContextOptions<BaseDbContext> dbContextOptions, IConfiguration configuration)
            : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //    base.OnConfiguring(
            //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SomeConnectionString")));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(a =>
            {
                a.ToTable("Brands").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
            });

            Brand[] brandEntitySeeds = { new Brand { Id = 1, Name = "BMW" }, new Brand { Id = 2, Name = "Mercedes" } };
            modelBuilder.Entity<Brand>().HasData(brandEntitySeeds);

            modelBuilder.Entity<SomeFeatureEntity>(a =>
            {
                a.ToTable("SomeFeatureEntities").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
            });
            SomeFeatureEntity[] someFeatureEntitySeeds = { new(1, "Test 1"), new(2, "Test 2") };
            modelBuilder.Entity<SomeFeatureEntity>().HasData(someFeatureEntitySeeds);

        }
    }
}
