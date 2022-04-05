using AcheFacilAPi.Domain.Entities;

namespace AcheFacilAPi.Domain.Models
{
    public class Address
    {
        public string? Estate { get; set; }
        public string? City { get; set; }
        public String? District { get; set; }
        public string? Street { get; set; }

        public  Guid? BusinessId { get; set; }
    }
}
