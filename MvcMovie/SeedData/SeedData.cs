using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Сheburashka",
                        ReleaseDate = DateTime.Parse("2023-01-01"),
                        Genre = "Family Comedy",
                        Rating = "6",
                        Price = 12.5M
                    },

                    new Movie
                    {
                        Title = "How to Train Your Dragon",
                        ReleaseDate = DateTime.Parse("2010-03-18"),
                        Genre = "Сartoon",
                        Rating = "6",
                        Price = 165M
                    },

                    new Movie
                    {
                        Title = "Home Alone",
                        ReleaseDate = DateTime.Parse("1990-11-10"),
                        Genre = "Family Comedy",
                        Rating = "0",
                        Price = 18M
                    },

                    new Movie
                    {
                        Title = "The Transporter",
                        ReleaseDate = DateTime.Parse("2002-10-02"),
                        Genre = "Action",
                        Rating = "16",
                        Price = 21M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}