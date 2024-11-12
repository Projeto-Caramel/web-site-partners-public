using Caramel.Website.Partners.Services.CustomConverters;
using System.Text.Json.Serialization;

namespace Caramel.Website.Partners.Models.Entities.Pets.Gallery
{
    public class PetGalleryImage
    {
        public string Id { get; set; }

        public string PetId { get; set; }

        public string ImageUrl { get; set; }
    }
}
