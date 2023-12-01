using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class PlaylistRepository : Playlist
    {
        private readonly PlaylistContext _repository;

        public PlaylistRepository()
        {
            _repository = new PlaylistContext();
        }

        public List<Songs> GetAllSongs()
        {
            return _repository.Songs.ToList();
        }

        public void AddSong(Songs song)
        {
           _repository.Songs.Add(song);
            _repository.SaveChanges();
            
        }

        public void UpdateSong(Songs song)
        {
            _repository.Songs.Update(song);
            _repository.SaveChanges();
        }

        public void DeleteSong(int id)
        {
            var song = _repository.Songs.Find(id);
            if (song != null)
            {
                _repository.Songs.Remove(song);
                _repository.SaveChanges();
            }
        }
    }
}

