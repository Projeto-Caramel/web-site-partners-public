using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models
{
    public class TokenModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Token { get; set; }
        public Roles Role { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
