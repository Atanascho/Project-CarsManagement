namespace CarsManagement.Data
{
    using CarsManagement.Data.Models;
    using Microsoft.EntityFrameworkCore;
    //Клас AppDbContext, чрез който се осъществява връзка с база данни
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-G15RSF8; Database=CarsDb; Trusted_Connection=True; TrustServerCertificate=True";
        public virtual DbSet<Manufacturer> Manufacturers  { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<ManufacturerCars> ManufacturerCars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
