using AcheFacilAPi.Domain.Entities;

namespace AcheFacilAPi.Domain.Models
{
    public class User : Entity
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public bool Active { get; set; }

        public ICollection<Business>? Business { get; set; }
    }
}
