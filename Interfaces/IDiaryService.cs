using Voyages.Data;

namespace Voyages.Interfaces
{
    public interface IDiaryService
    {
        Task<List<Diary>> GetAllDiaries();
        Task<Diary?> GetDiaryById(int id);
        Task<List<Diary>> GetDiariesByUserId(int userId);
        Task Create(Diary diary);
        Task Update(Diary diary);
        Task Delete(Diary diary);
    }
}
