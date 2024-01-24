using System.ComponentModel.DataAnnotations.Schema;
using Voyages.Data;

namespace Voyages.DTOs.Responses
{
    public class LikedDiaryResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserResponse User { get; set; }
        public int DiaryId { get; set; }
        public DiaryResponse Diary { get; set; }
    }
}
