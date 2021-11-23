using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCampCourseCsharp
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating; // Ratings should only be G, PG, PG-13, R, NR
        // therefore the rating is private which will not allow other program to acces it 

        public Movie(string movieTitle, string movieDirector, string movieRating)
        {
            title = movieTitle;
            director = movieDirector;
            Rating  = movieRating;

        }
        public string Rating 
        { 
            get { return rating; }
            set { 
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;

                }
                else
                {
                    rating = "NR";
                }; 
            } 
        }
    }
}
