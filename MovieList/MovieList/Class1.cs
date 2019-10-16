using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
   public class Movie
    {
        public string Title;
        public int ReleaseYear;
        public string Director;
        public int Length;
        public string Genre;
        public Movie(string title, int releaseYear, string director, int length, string genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
            Genre = Genre;


        }
        public void ShowDetails()
        {
            MessageBox.Show(Title + "was released in" + ReleaseYear + "And it's director was" + Director + "it is");
        }

    }
}
