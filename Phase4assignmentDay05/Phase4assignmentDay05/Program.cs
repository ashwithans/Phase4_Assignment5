// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
}

public class MovieManager
{
    private List<Movie> movies;

    public MovieManager()
    {
        movies = new List<Movie>
        {
           new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16) },
    new Movie { Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateTime(2008, 7, 18) },
    new Movie { Id = 3, Title = "Forrest Gump", Genre = "Drama", ReleaseDate = new DateTime(1994, 7, 6) },
    new Movie { Id = 4, Title = "Pulp Fiction", Genre = "Crime", ReleaseDate = new DateTime(1994, 10, 14) },
    new Movie { Id = 5, Title = "The Matrix", Genre = "Sci-Fi", ReleaseDate = new DateTime(1999, 3, 31) },
        };
    }

    public List<Movie> GetAllMovies()
    {
        return movies;
    }

    public Movie GetMovieByTitle(string title)
    {
        return movies.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
}

class Program
{
    static void Main()
    {
        MovieManager movieManager = new MovieManager();

        Console.WriteLine("All Movies:");
        foreach (var movie in movieManager.GetAllMovies())
        {
            Console.WriteLine($"{movie.Title} - {movie.Genre} - {movie.ReleaseDate}");
        }

        Console.Write("\nEnter the title of the movie to retrieve: ");
        string inputTitle = Console.ReadLine();

        Movie foundMovie = movieManager.GetMovieByTitle(inputTitle);

        if (foundMovie != null)
        {
            Console.WriteLine($"\nMovie Found: {foundMovie.Title} - {foundMovie.Genre} - {foundMovie.ReleaseDate}");
        }
        else
        {
            Console.WriteLine("\nMovie not found.");
        }
        Console.ReadKey();
    }
}

