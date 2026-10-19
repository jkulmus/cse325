using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>());

        var movies = new Movie[]
        {
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = new DateTime(1989, 2, 12),
                Genre = "Romantic Comedy",
                Rating = "R",
                Price = 7.99M
            },
            new Movie
            {
                Title = "Ghostbusters",
                ReleaseDate = new DateTime(1984, 3, 13),
                Genre = "Comedy",
                Rating = "G",
                Price = 8.99M
            },
            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = new DateTime(1986, 2, 23),
                Genre = "Comedy",
                Rating = "G",
                Price = 9.99M
            },
            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = new DateTime(1959, 4, 15),
                Genre = "Western",
                Rating = "NA",
                Price = 3.99M
            },
            new Movie
            {
                Title = "Remember the Titans",
                ReleaseDate = new DateTime(2000, 9, 29),
                Genre = "Sports Drama",
                Rating = "PG",
                Price = 9.99M
            },
            new Movie
            {
                Title = "The Wizard of Oz",
                ReleaseDate = new DateTime(1939, 8, 25),
                Genre = "Musical Fantasy",
                Rating = "G",
                Price = 7.99M
            },
            new Movie
            {
                Title = "The Devil Wears Prada",
                ReleaseDate = new DateTime(2006, 6, 30),
                Genre = "Comedy Drama",
                Rating = "PG-13",
                Price = 9.99M
            }
        };

        // Add each seed movie only if its title and release date
        // are not already in the database.
        foreach (var movie in movies)
        {
            bool alreadyExists = context.Movie.Any(m =>
                m.Title == movie.Title &&
                m.ReleaseDate == movie.ReleaseDate);

            if (!alreadyExists)
            {
                context.Movie.Add(movie);
            }
        }

        context.SaveChanges();
    }
}