using System;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var ws = new Movie();
            ws.Id = 1;
            ws.Title = "Captain America Winter Soldier";
            ws.Genre = "Action";
            ws.Rating = "PG-13";
            ws.Released = 2014;
            ws.SetRunTimeInMinutes(2, 16);
            ws.Director = "Joe Russo";

            Console.WriteLine($" The Movie {ws.Title} has an Id of {ws.Id}. It is a {ws.Rating} {ws.Genre} movie that was released in {ws.Released}. " +
                $"It was directed by {ws.Director} and is {ws.RunTimeInMinutes} mintues long");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            
            var im1 = new Movie();
            im1.Id = 2;
            im1.Title = "Iron man";
            im1.Genre = "Super hero";
            im1.Rating = "PG-13";
            im1.Released = 2008;
            im1.SetRunTimeInMinutes(2, 6);
            im1.Director = "Jon Favreau";

            Console.WriteLine($" The Movie {im1.Title} has an Id of {im1.Id}. It is a {im1.Rating} {im1.Genre} movie that was released in {im1.Released}. " +
                $"It was directed by {im1.Director} and is {im1.RunTimeInMinutes} mintues long");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            
            var eg = new Movie();
            eg.Id = 3;
            eg.Title = "Avengers End Game";
            eg.Genre = "Action";
            eg.Rating = "PG-13";
            eg.Released = 2019;
            eg.SetRunTimeInMinutes(3,2);
            eg.Director = "Anthony Russo";
            Console.WriteLine($" The Movie {eg.Title} has an Id of {eg.Id}. It is a {eg.Rating} {eg.Genre} movie that was released in {eg.Released}. " +
                $"It was directed by {eg.Director} and is {eg.RunTimeInMinutes} mintues long");
        }
    }
}
