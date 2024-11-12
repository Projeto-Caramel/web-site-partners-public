namespace Caramel.Website.Partners.Models.Entities.Pets
{
    public class Pet
    {
        public string Id { get; set; }
        public string PartnerId { get; set; }
        public PetInfo Info { get; set; } = new();
        public PetHealthy Healthy { get; set; } = new();
        public PetCharacteristics Caracteristics { get; set; } = new();
    }
}
