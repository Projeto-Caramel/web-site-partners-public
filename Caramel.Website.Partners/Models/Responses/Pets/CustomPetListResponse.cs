using Caramel.Website.Partners.Models.Entities.Pets;
using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.Pets
{
    public class CustomPetListResponse
    {
        public IEnumerable<Pet> Data { get; set; }
        public StatusProcess Status { get; set; }
        public string Description { get; set; }
        public int Total { get; set; }
    }
}
