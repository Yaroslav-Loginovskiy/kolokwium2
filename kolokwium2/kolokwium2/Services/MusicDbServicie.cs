using kolokwium2.Models;
using kolokwium2.Models.DTOs.Responses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
    public class MusicDbServicie : IMusicDbService
    {
        private readonly MainDbContext _context;
        public MusicDbServicie(MainDbContext context)
        {
            _context = context;
        }
        public void DeleteMusician(int id)
        {
            var musician = _context.Musicians
                 .Include(a => a.Musician_Tracks)
               

        }

        public GetAlbumResponse GetAlbum(int id)
        {
            var album = _context.Albums
                .Include(a => a.Tracks)
                .FirstOrDefault(m => m.IdAlbum == id);

            if (album == null)
            {
                throw new Exception("Albums does not exists!");

            }

            var tracks = _context.Tracks
                .Where(p => p.IdMusicAlbum == id).OrderBy(a =>a.Duration).ToList();

            var response = new GetAlbumResponse
            {
                AlbumName = album.AlbumName,
                Tracks = tracks
            };
            return response;
        }
    }
}
