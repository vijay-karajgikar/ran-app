using RanApp.DataAccess.Domain;
using Microsoft.EntityFrameworkCore;

namespace RanApp.DataAccess.Repository
{
    public class RanDbContext : DbContext
    {
        public RanDbContext(DbContextOptions<RanDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=randb;User Id=SA;Password=test123!;TrustServerCertificate=True");
            }
        }

        public DbSet<Rider> Riders { get; set; }

        public DbSet<RiderAddress> RiderAddresses { get; set; }

        public DbSet<RiderAppointment> RiderAppointments { get; set; }

        public DbSet<RideType> RideTypes { get; set; }
    }
}