using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Movie
    {
        private static int NextId { get; set; } = 1;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; } = "PG";
        public int Released { get; set; } //year only
        public int RunTimeInMinutes { get; set; }
        public string Director { get; set; }

        public static int SetRunTimeInMinutes(int Hours, int Minutes)
        {
          return Hours * 60 + Minutes;
        }
        


        public Movie() { } //default constructor

        public Movie(string title, string genre, string rating, int released, int runtimeinminutes, string director) //constructor
        {
            this.Id = NextId++;
            if (NextId > 2) {
                NextId = 1;
            }

            this.Title = title;
            this.Genre = genre;
            this.Rating = rating;
            this.Released = released;
            this.RunTimeInMinutes = runtimeinminutes;
            this.Director = director;
        }
        
   
    }
    
       
    
}//create a method to calculate runtimeinminutes with 2 int parameters and load it into a property and create 5 movies
