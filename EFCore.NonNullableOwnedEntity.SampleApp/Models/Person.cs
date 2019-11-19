using System.ComponentModel.DataAnnotations;

namespace EFCore.NonNullableOwnedEntity.SampleApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Metric Metric { get; set; }
    }
}
