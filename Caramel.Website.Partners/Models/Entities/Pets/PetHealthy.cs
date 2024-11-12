using Caramel.Website.Partners.Models.Enums.Pets;

namespace Caramel.Website.Partners.Models.Entities.Pets
{
    public class PetHealthy
    {
        public CastratedStatus Castrated { get; set; }
        public VaccinatedStatus Vaccinated { get; set; }
    }
}
