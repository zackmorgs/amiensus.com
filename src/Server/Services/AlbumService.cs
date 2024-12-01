using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;

namespace Server.Services {
    public class AlbumService {
        public AlbumService(AmiensusDb context) {
            _context = context;
        }
        private AmiensusDb _context { get; set;}

        public async Task AddAlbum(Album album) {
            _context.Albums.Add(album);
            _context.SaveChanges();
        }

        public async Task DeleteAlbum(int id) {
            var album = await _context.Albums.FindAsync(id);
            _context.Albums.Remove(album);
            _context.SaveChanges();
        }

        public async Task<List<Album>> GetAllAlbums() {
            var albums = await _context.Albums.ToListAsync();
            return albums;
        }

    }
}