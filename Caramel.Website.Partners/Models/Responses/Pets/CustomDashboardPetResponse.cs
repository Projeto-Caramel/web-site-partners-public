using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.Pets
{
    public class CustomDashboardPetResponse
    {
        public DashboardData Data { get; set; }
        public StatusProcess Status { get; set; }
        public string Description { get; set; }
    }
}
