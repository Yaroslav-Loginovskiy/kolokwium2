using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Musician_Track
    {
        public int IdTrack { get; set; }
        public int IdMusician { get; set; }

        public virtual Track IdTrackNav { get; set; }
        public virtual Musician IdMusicianNav { get; set; }
    }
}
