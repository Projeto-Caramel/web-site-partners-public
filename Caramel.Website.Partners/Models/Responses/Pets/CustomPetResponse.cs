using Caramel.Website.Partners.Models.Entities.Pets;
using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.Pets
{
    public class CustomPetResponse
    {
        public Pet Data { get; set; }
        public StatusProcess status { get; set; }
        public string Description { get; set; }
    }
}
