using Voyages.Data;

namespace Voyages.Interfaces
{
    public interface IDiaryLikeService
    {
        Task<List<LikedDiary>> GetAllDiaryLikes();
        Task<LikedDiary?> GetDiaryLikeById(int id);
        Task Create(LikedDiary likedDiary);
        Task Update(LikedDiary likedDiary);
        Task Delete(LikedDiary likedDiary);
    }
}
