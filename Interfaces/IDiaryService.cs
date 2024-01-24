using Voyages.Data;

namespace Voyages.Interfaces
{
    public interface IDiaryService
    {
        Task<List<Diary>> GetAllDiaries();
        Task<Diary?> GetDiaryById(int id);
        Task Create(Diary diary);
        Task Update(Diary diary);
        Task Delete(Diary diary);
    }
}
