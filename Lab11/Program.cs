﻿using System;
using System.Collections.Generic;

namespace Lab11
{
    public class Class
    {
        static void Main()
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

            //Movie List Declaration
            List<Movie> movies = new List<Movie> {weathering, voice, gumby, lotr1, lotr2, lotr3, thing, shining, mandy, blade, district, primer};

            //Loop to run main program, continues indefinitely if user wishes.
            while (loop)
            {
                Console.WriteLine("Welcome to the Movie Database.");
                string input = "error";

                while (input == "error")
                {
                    input = SelectGenre();
                }

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

                //Alphabetize results list
                movieTitles.Sort();

                Console.WriteLine();
                Console.WriteLine("Displaying Results Now:");
                Console.WriteLine("=======================");

                foreach (string title in movieTitles)
                {
                    Console.WriteLine(title);
                }

                Console.WriteLine();

                loop = AskLoop();
            }
            //exits program when user does not wish to continue using the loop
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Movie Database. Goodbye");
            Environment.Exit(1);
        }
        public static bool AskLoop()
        {
            string input = "error";
            bool loop = false;

            while (input == "error")
            {
                Console.WriteLine("Would you like to search again? (yes/no)");
                input = Console.ReadLine();
                input.ToLower().Trim();

                if (input != "yes" && input != "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter yes or no. Would you like to search again?");
                    input = "error";
                }
            }

            if (input == "yes")
            {
                Console.WriteLine();
                loop = true;
            }

            return loop;
        }

        public static string SelectGenre()
        {
            string answer = "error";
            int compare = 0;

            Console.WriteLine("Please select a genre of movie to search for:");
            Console.WriteLine("=============================================");
            Console.WriteLine("1: Animation");
            Console.WriteLine("2: Fantasy");
            Console.WriteLine("3: Horror");
            Console.WriteLine("4: SciFi");
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Console.WriteLine("Please select an input based on its assigned number.");

            //Input validation in the event a non integer is entered
            try
            {
                compare = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input a valid integer for your selection");
                Console.WriteLine();
            }

            //chooses a genre based on integer selected
            switch (compare)
            {
                case 1: answer = "Animation";
                    break;
                case 2: answer = "Fantasy";
                    break;
                case 3: answer = "Horror";
                    break;
                case 4: answer = "SciFi";
                    break;
                default:
                    Console.WriteLine("Please select a displayed integer.");
                    Console.WriteLine();
                    break;
            }
            return answer;
        }
    }
}
    