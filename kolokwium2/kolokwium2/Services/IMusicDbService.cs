using kolokwium2.Models.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
   public interface IMusicDbService
    {
        GetAlbumResponse GetAlbum(int id);
        void DeleteMusician(int id);
    }
}
