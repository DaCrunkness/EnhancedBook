using DataAccess.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using Models.DataModels;

namespace DataAccess.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategorySeed());

        }

        public DbSet<Category> Categories { get; set; }
    }
}
