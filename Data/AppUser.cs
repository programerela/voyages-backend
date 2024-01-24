using Microsoft.AspNetCore.Identity;

namespace Voyages.Data
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public List<Diary> Diaries { get; set; } = new();
        public List<LikedDiary> LikedDiaries { get; set; } = new();
    }
}
