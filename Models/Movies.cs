using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Movies.Models
{
    internal class Movies
    {
        public int PKMovie { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }
        public int FKDirector { get; set; }
        public Movies(int pKMovie, string title, string genre, TimeSpan duration, int fKDirector)
        {
            PKMovie = pKMovie;
            Title = title;
            Genre = genre;
            Duration = duration;
            FKDirector = fKDirector;
        }
    }
}
