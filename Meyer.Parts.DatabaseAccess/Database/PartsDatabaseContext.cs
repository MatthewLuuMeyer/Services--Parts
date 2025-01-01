using System.Linq;
using Meyer.Parts.DatabaseAccess.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meyer.Parts.DatabaseAccess.Database
{
    public class PartsDatabaseContext(DbContextOptions<PartsDatabaseContext> options) : DbContext(options)
    {
        public DbSet<ItemQuantityMasterEntity> ItemQuantities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Switch all strings to VARCHAR instead of NVARCHAR.
            //Strings default to NVARCHAR with Entity Framework.
            foreach (var property in modelBuilder.Model
                         .GetEntityTypes()
                         .SelectMany(t => t.GetProperties())
                         .Where(
                             p => p.ClrType == typeof(string) && p.GetColumnType() == null
                         ))
            {
                property.SetIsUnicode(false);
            }
        }
    }
}
