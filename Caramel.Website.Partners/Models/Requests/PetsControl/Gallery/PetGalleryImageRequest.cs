namespace Caramel.Website.Partners.Models.Requests.PetsControl.Gallery
{
    public class PetGalleryImageRequest
    {
        public PetGalleryImageRequest() { }

        public PetGalleryImageRequest(string petId, string image)
        {
            PetId = petId;
            Base64Image = image;
        }

        public string PetId { get; set; }
        public string Base64Image { get; set; }
    }
}
