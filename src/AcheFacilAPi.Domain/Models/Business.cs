using AcheFacilAPi.Domain.Entities;

namespace AcheFacilAPi.Domain.Models
{
    public class Business : Entity
    {
        public string? Name { get; set; }
        public Address? Adress { get; set; }
        public string? Profession { get; set; }
        public string? Image { get; set; }
        public Contacts? Contacts { get; set; }
        public bool Active { get; set; }

        public ICollection<Proficiency>? Proficiencies { get; set; }


    }
}
