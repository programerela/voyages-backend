namespace Voyages.DTOs.Requests
{
    public class UserLoginRequest
    {
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string Password { get; set; }
    }
}
