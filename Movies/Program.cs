using System;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var ws = new Movie
                ( "Captain America Winter Soldier", "Action", "PG-13", 2014, Movie.SetRunTimeInMinutes(2,16), "Joe Russo");

            Console.WriteLine($" The Movie {ws.Title} has an Id of {ws.Id}. It is a {ws.Rating} {ws.Genre} movie that was released in {ws.Released}. " +
                $"It was directed by {ws.Director} and is {ws.RunTimeInMinutes} mintues long");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            
            
            var im1 = new Movie
                ( "Iron man", "Super Hero", "PG-13", 2008, Movie.SetRunTimeInMinutes(2,6), "Jon Favreau");

            Console.WriteLine($" The Movie {im1.Title} has an Id of {im1.Id}. It is a {im1.Rating} {im1.Genre} movie that was released in {im1.Released}. " +
                $"It was directed by {im1.Director} and is {im1.RunTimeInMinutes} mintues long");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            
           
            var eg = new Movie
              ( "Avengers End Game", "Action", "PG-13", 2019, Movie.SetRunTimeInMinutes(2, 6), "Anthony Russo") ;
        
            Console.WriteLine($" The Movie {eg.Title} has an Id of {eg.Id}. It is a {eg.Rating} {eg.Genre} movie that was released in {eg.Released}. " +
                $"It was directed by {eg.Director} and is {eg.RunTimeInMinutes} mintues long");
            
        }

     
    }
}
