using Caramel.Website.Partners.Models.Entities.Pets.Gallery;
using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.Pets
{
    public class CustomPetGalleryResponse
    {
        public IEnumerable<PetGalleryImage> Data { get; set; }
        public StatusProcess status { get; set; }
        public string Description { get; set; }
    }
}
