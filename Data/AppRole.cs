using Microsoft.AspNetCore.Identity;

namespace Voyages.Data
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole(string name) : base(name)
        {
            
        }
    }
}
