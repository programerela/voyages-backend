using Voyages.Data;

namespace Voyages.Interfaces
{
    public interface IUserService
    {
        string GenerateToken(AppUser user, string role);
    }
}
