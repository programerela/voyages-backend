namespace Voyages.DTOs.Responses
{
    public class AuthResponse
    {
        public UserResponse User { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
