namespace Voyages.DTOs.Requests
{
    public class CreateLikedDiaryRequest
    {
        public int UserId { get; set; }
        public int DiaryId { get; set; }
    }
}
