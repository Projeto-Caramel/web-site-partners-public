using Caramel.Website.Partners.Models.Entities.Partner;
using SixLabors.ImageSharp.Advanced;

namespace Caramel.Website.Partners.Models.Requests.UsersControl
{
    public class PartnerUpdateRequest
    {
        public PartnerUpdateRequest(Partner partner, string base64Image)
        {
            Map(partner, base64Image);
        }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Cellphone { get; set; }
        public string CNPJ { get; set; }
        public string AdoptionRate { get; set; }
        public string PIX { get; set; }
        public string Website { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Base64Image { get; set; }
        public int MaxCapacity { get; set; }

        private void Map(Partner partner, string base64Image)
        {
            Email = partner.Email;
            Name = partner.Name;
            Description = partner.Description;
            Address = partner.Address;
            Cellphone = partner.Cellphone;
            CNPJ = partner.CNPJ;
            AdoptionRate = partner.AdoptionRate;
            PIX = partner.PIX;
            Website = partner.Website;
            Instagram = partner.Instagram;
            Facebook = partner.Facebook;
            MaxCapacity = partner.MaxCapacity;
            Base64Image = base64Image;
        }
    }
}
