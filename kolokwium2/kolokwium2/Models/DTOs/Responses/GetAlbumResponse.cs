using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models.DTOs.Responses
{
    public class GetAlbumResponse
    {
        public string AlbumName { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
