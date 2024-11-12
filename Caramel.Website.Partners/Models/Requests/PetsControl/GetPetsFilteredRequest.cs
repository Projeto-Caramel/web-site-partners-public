using Caramel.Website.Partners.Models.Entities;
using Caramel.Website.Partners.Models.Entities.Pets;

namespace Caramel.Website.Partners.Models.Requests.PetsControl
{
    public class GetPetsFilteredRequest
    {
        public Pagination Pagination { get; set; }
        public PetFilter PetFilter { get; set; }
    }
}
