using Voyages.Data;

namespace Voyages.DTOs.Responses
{
    public class DiaryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string OverratedSpots { get; set; }
        public string UnderratedSpots { get; set; }
        public int Rating { get; set; } // Assuming 1-5 star rating
        public int LikeCount { get; set; }
        public bool IsPublic { get; set; }
        public int UserId { get; set; } // Foreign key for User
        public UserResponse User { get; set; }
        public List<LikedDiariesDto> LikedDiaries { get; set; } = new();
    }
}
