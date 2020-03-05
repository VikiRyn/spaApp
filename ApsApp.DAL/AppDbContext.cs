using ApsApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApsApp.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=appDB;Trusted_Connection=True;MultipleActiveResultSets=true");

        public DbSet<AccommodationDal> Accommodations { get; set; }
    }
}
