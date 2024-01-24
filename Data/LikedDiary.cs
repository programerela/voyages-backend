using System.ComponentModel.DataAnnotations.Schema;

namespace Voyages.Data
{
    public class LikedDiary
    {
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public AppUser User { get; set; }
        [ForeignKey(nameof(Diary))]
        public int DiaryId { get; set; }
        public Diary Diary { get; set; }
    }
}
