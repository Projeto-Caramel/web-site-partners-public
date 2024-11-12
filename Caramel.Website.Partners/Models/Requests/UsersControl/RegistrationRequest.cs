namespace Caramel.Website.Partners.Models.Requests.UsersControl
{
    public class RegistrationRequest
    {
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Role { get; set; } = 1;
        public int MaxCapacity { get; set; } = 1;
    }
}
