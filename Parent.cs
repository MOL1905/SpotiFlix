using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiFlix
{
    internal abstract class Parent
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int LengthInSeconds { get; set; }
        public string Www { get; set; }
    }
    enum Genre
    {
        Action = 1, Comedy, Drama, Horror, Thriller, ScienceFiction
    }
}
