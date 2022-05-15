using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiFlix
{
    internal class Music : Parent 
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public MusicGenre Genre { get; set; }
        public string GetTime()
        {
            int minutes = LengthInSeconds / 60;
            //We take the rest after dividing with 60 to get seconds
            int seconds = LengthInSeconds % 60;
            return $"{minutes}M:{seconds}S";
        }
        public void Show()
        {
            Console.WriteLine($"{Title} {Album} {Artist}");
        }
    }
    public enum MusicGenre
    {
        Pop = 1, Rock, HipHop, Latin, Electronica
    }
}
