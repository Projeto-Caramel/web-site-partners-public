using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.Auth
{
    public class CodeResponse
    {
        public TokenModel Data { get; set; }
        public StatusProcess Status { get; set; }
        public string Description { get; set; }
    }
}
