using Caramel.Website.Partners.Models.Enums.Pets;

namespace Caramel.Website.Partners.Models.Entities.Pets
{
    public class PetInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public PetStatus Status { get; set; }
        public string ProfileImageUrl { get; set; }
        public DateTime AdoptionDate { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
