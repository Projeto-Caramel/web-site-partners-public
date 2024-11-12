using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Entities.Partner
{
    public class Partner
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Cellphone { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string AdoptionRate { get; set; } = string.Empty;
        public string PIX { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string Instagram { get; set; } = string.Empty;
        public string Facebook { get; set; } = string.Empty;
        public OrganizationType Type { get; set; }
        public Roles Role { get; set; }
        public string ProfileImageUrl { get; set; }
        public int MaxCapacity { get; set; }
    }
}
