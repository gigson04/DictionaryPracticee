using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPracticee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a dictionary to store movie titles and release years 
            // I used STRING for the name of the movie and INT for the release year
            Dictionary<string, int> movies = new Dictionary<string, int>();

            // Add some movies
            movies["The Shawshank Redemption"] = 1994;
            movies["The Godfather"] = 1972;
            movies["The Dark Knight"] = 2008;

            while (true)
            {
                // This is the main menu, as you can see I put some options for the user to choose from
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. View Movie");
                Console.WriteLine("3. List All Movies");
                Console.WriteLine("4. Exit");
                // And this is where we get the user's choice
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine(); // This is where we get the user's choice

                if (choice == "1") // This is where we handle the user's choice
                {
                    Console.WriteLine("Enter the movie title: "); // The user will be asked what movie they want to add
                    string title = Console.ReadLine();
                    Console.WriteLine(
                        "Enter the release year: "); // The user will be asked what year the movie was released
                    if (int.TryParse(Console.ReadLine(), out int year))
                    {
                        movies[title] = year; // Overwrites if exists
                        Console.WriteLine("Added!");
                    }
                    else if (choice == "2")
                        Console.WriteLine("Movie Title: ");

                    string movieTitle = Console.ReadLine();
                    if (movies.TryGetValue(movieTitle, out int releaseYear))
                    {
                        Console.WriteLine($"Release Year: {releaseYear}");
                    }
                    else
                    {
                        Console.WriteLine("Movie not found.");
                    }
                }

                else if (choice == "3")
                {
                    Console.WriteLine("All Movies:"); // Prints all movies
                    foreach (var movie in movies) // I choose var because it generic 
                    {
                        Console.WriteLine($"{movie.Key} ({movie.Value})");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exiting...");
                }
                break;
                // 
                //
                //
            }
        }
    }

}
    