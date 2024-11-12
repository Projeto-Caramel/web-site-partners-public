using Caramel.Website.Partners.Models.Enums;

namespace Caramel.Website.Partners.Models.Responses.UsersControl
{
    public class CustomResponse<T>
    {
        public T Data { get; set; }
        public StatusProcess Status { get; set; }
        public string Description { get; set; }
    }
}
