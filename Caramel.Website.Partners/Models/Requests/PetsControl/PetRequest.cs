using Caramel.Website.Partners.Models.Entities.Pets;
using Caramel.Website.Partners.Models.Enums.Pets;
using Caramel.Website.Partners.Services.CustomConverters;
using System.Text.Json.Serialization;

namespace Caramel.Website.Partners.Models.Requests.PetsControl
{
    public record PetRequest(string PartnerId, PetInfoRequest Info, PetHealthy Healthy, PetCharacteristics Caracteristics);

    public class PetInfoRequest
    {
        public PetInfoRequest() { }

        public PetInfoRequest(string name, string description, DateTime birthDate, PetStatus status, string base64Image)
        {
            Name = name;
            Description = description;
            BirthDate = birthDate;
            Status = status;
            Base64Image = base64Image;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public PetStatus Status { get; set; }
        public string Base64Image { get; set; }
    }

    public record PetEditRequest(string PartnerId, PetInfoEditRequest Info, PetHealthy Healthy, PetCharacteristics Caracteristics);

    public class PetInfoEditRequest
    {
        public PetInfoEditRequest()
        {

        }

        public PetInfoEditRequest(string name, string description, DateTime birthDate, PetStatus status, string base64Image, DateTime adoptionDate)
        {
            Name = name;
            Description = description;
            BirthDate = birthDate;
            Status = status;
            Base64Image = base64Image;
            AdoptionDate = adoptionDate;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public PetStatus Status { get; set; }
        public string Base64Image { get; set; }
        public DateTime AdoptionDate { get; set; }
    }
}
