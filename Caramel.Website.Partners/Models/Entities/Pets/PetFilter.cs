using Caramel.Website.Partners.Models.Enums.Pets;

namespace Caramel.Website.Partners.Models.Entities.Pets
{
    public class PetFilter
    {
        public string Name { get; set; }
        public CastratedStatus Castrated { get; set; }
        public VaccinatedStatus Vaccinated { get; set; }
        public AgeType Age { get; set; }
        public PetStatus Status { get; set; }
        public PetSex Sex { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
