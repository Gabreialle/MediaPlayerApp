namespace MusicPlayerApp
{
    public interface Playlist
    {
        public void AddSong(Songs song);
        public void UpdateSong(Songs song);
        public void DeleteSong(int id);
        public List<Songs> GetAllSongs();


    }
}
