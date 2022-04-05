namespace AcheFacilAPi.Domain.Models
{
    public class Contacts
    {
        public string? Email { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }
        public string? Phone { get; set; }
        public string? Zap { get; set; }

        public Guid BusinessId { get; set; }
    }
}
