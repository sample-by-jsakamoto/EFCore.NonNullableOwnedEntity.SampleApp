using EFCore.NonNullableOwnedEntity.SampleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.NonNullableOwnedEntity.SampleApp.Data
{
    public class SampleDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }
    }
}
