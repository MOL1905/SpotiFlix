using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiFlix
{
    internal class Data
    {
        public List<Music> MusicList { get; set; } = new List<Music>();
        public List<Movies> MovieList { get; set; } = new List<Movies>();
        public List<Series> SeriesList { get; set; } = new List<Series>();

    }
}
