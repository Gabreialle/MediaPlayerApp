using Microsoft.EntityFrameworkCore;
using MusicPlayerApp;

namespace MusicPlayerApp
{
    public class PlaylistContext : DbContext
    {
        public DbSet<Songs> Songs { get; set; }

        public string DbPath { get; }

        public PlaylistContext()
        {
            var path = Directory.GetCurrentDirectory();
            DbPath = Path.Join(path, "songs.db");
            Database.EnsureCreated();
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
        }
    }






