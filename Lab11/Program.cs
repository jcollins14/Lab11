using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public Movie(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }
    }
    class Program
    {
        public enum Genre
        {
            Animation,
            Fantasy,
            Horror,
            SciFi
        }
        static void Main(string[] args)
        {
            bool loop = true;

            //Movie Object Declaration/Instantiation
            Movie weathering = new Movie("Weathering with You (2019)", "Animation");
            Movie voice = new Movie("A Silent Voice (2016)", "Animation");
            Movie gumby = new Movie("Gumby: The Movie (1995)", "Animation");
            Movie lotr1 = new Movie("Lord of the Rings: Fellowship of the Ring (2001)", "Fantasy");
            Movie lotr2 = new Movie("Lord of the Rings: The Two Towers (2002)", "Fantasy");
            Movie lotr3 = new Movie("Lord of the Rings: The Return of the King (2003)", "Fantasy");
            Movie thing = new Movie("The Thing (1982)", "Horror");
            Movie shining = new Movie("The Shining (1980)", "Horror");
            Movie mandy = new Movie("Mandy (2018)", "Horror");
            Movie blade = new Movie("Blade Runner (1982)", "SciFi");
            Movie district = new Movie("District 9 (2009)", "SciFi");
            Movie primer = new Movie("Primer (2004)", "SciFi");

            //Movie Array Declaration
            Movie[] movies = new Movie[12];

            movies[0] = weathering;
            movies[1] = voice;
            movies[2] = gumby;
            movies[3] = lotr1;
            movies[4] = lotr2;
            movies[5] = lotr3;
            movies[6] = thing;
            movies[7] = shining;
            movies[8] = mandy;
            movies[9] = blade;
            movies[10] = district;
            movies[11] = primer;

            while (loop)
            {
                Console.WriteLine("Welcome to the Movie Database. What Genre would you like to search for?");
                string input = Console.ReadLine();

                List<string> movieTitles = new List<string>();

                //add searched genre to list IF it is not already present
                foreach (Movie movie in movies)
                {
                    if (input == movie.Genre)
                    {
                        if (!movieTitles.Contains(movie.Title))
                        {
                            movieTitles.Add(movie.Title);
                        }
                    }
                }

                //remove previously searched genres from list
                foreach (Movie movie in movies)
                {
                    if (input != movie.Genre)
                    {
                        movieTitles.Remove(movie.Title);
                    }
                }

                movieTitles.Sort();

                Console.WriteLine();
                Console.WriteLine("Displaying Results Now:");
                Console.WriteLine("=======================");

                foreach (string title in movieTitles)
                {
                    Console.WriteLine(title);
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to search again?");
                input = Console.ReadLine();
                loop = false;

                if (input == "yes")
                {
                    loop = true;
                }
            }

            Console.WriteLine("Thank you for using the Movie Database. Goodbye");
            Environment.Exit(1);
        }
    }
}