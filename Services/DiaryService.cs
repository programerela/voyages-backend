using Microsoft.EntityFrameworkCore;
using Voyages.Data;
using Voyages.Interfaces;

namespace Voyages.Services
{
    public class DiaryService : IDiaryService
    {
        private readonly DatabaseContext _context;

        public DiaryService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task Create(Diary diary)
        {
            await _context.Diaries.AddAsync(diary);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Diary diary)
        {
            _context.Diaries.Remove(diary);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Diary>> GetAllDiaries() =>
            await _context.Diaries.Include(x => x.User).Include(x => x.LikedDiaries).ToListAsync();

        public async Task<Diary?> GetDiaryById(int id) =>
            await _context.Diaries.Include(x => x.User).Include(x => x.LikedDiaries).Where(x => x.Id == id).FirstOrDefaultAsync();

        public async Task Update(Diary diary)
        {
            _context.Diaries.Update(diary);
            await _context.SaveChangesAsync();
        }
    }
}
