using Microsoft.EntityFrameworkCore;
using Voyages.Data;
using Voyages.Interfaces;

namespace Voyages.Services
{
    public class DiaryLikeService : IDiaryLikeService
    {
        private readonly DatabaseContext _context;

        public DiaryLikeService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task Create(LikedDiary likedDiary)
        {
            await _context.LikedDiaries.AddAsync(likedDiary);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(LikedDiary likedDiary)
        {
            _context.LikedDiaries.Remove(likedDiary);
            await _context.SaveChangesAsync();
        }

        public async Task<List<LikedDiary>> GetAllDiaryLikes() =>
            await _context.LikedDiaries.Include(x => x.Diary).Include(x => x.User).ToListAsync();

        public async Task<LikedDiary?> GetDiaryLikeById(int id) =>
            await _context.LikedDiaries.Include(x => x.Diary).Include(x => x.User).Where(x => x.Id == id).FirstOrDefaultAsync();

        public async Task Update(LikedDiary likedDiary)
        {
            _context.LikedDiaries.Update(likedDiary);
            await _context.SaveChangesAsync();
        }
    }
}
