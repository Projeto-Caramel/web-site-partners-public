using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.Auth
{
    public class AuthResponse
    {
        public TokenModel Token { get; set; }
        public StatusProcess Status { get; set; }
        public string Description { get; set; }
    }
}
