using Caramel.Website.Partners.Models.Entities;
using Caramel.Website.Partners.Models.Entities.Partner;

namespace Caramel.Website.Partners.Models.Requests.UsersControl
{
    public class GetPartnersFilteredRequest
    {
        public Pagination Pagination { get; set; }
        public PartnerFilter PartnerFilter { get; set; }
    }
}
