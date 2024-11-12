using Caramel.Website.Partners.Models.Entities.Pets.Gallery;
using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.Pets
{
    public class CustomPetGalleryPictureResponse
    {
        public PetGalleryImage Data { get; set; }
        public StatusProcess Status { get; set; }
        public string Description { get; set; }
    }
}
