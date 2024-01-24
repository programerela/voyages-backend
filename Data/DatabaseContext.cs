using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Voyages.Data
{
    public class DatabaseContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<LikedDiary> LikedDiaries { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
