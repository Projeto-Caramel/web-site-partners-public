using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.Auth
{
    public class EmailResponse
    {
        public string Id { get; set; }
        public StatusProcess Status { get; set; }
        public string Description { get; set; }
    }
}
