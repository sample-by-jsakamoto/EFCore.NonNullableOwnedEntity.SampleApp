using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCore.NonNullableOwnedEntity.SampleApp.Data
{
    public class SampleDbContextFactory : IDesignTimeDbContextFactory<SampleDbContext>
    {
        public SampleDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<SampleDbContext>()
                .UseSqlServer("Server=(LocalDB)\\MSSqlLocalDb")
                .Options;
            return new SampleDbContext(options);
        }
    }
}
