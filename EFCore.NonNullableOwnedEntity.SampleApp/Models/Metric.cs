using Microsoft.EntityFrameworkCore;

namespace EFCore.NonNullableOwnedEntity.SampleApp.Models
{
    [Owned]
    public class Metric
    {
        public double Height { get; set; }

        public double Weight { get; set; }
    }
}
