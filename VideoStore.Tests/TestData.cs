using System.Collections.Generic;
using System.Linq;
using VideoStore.Common.Models;

namespace VideoStore.Tests
{
    public static class TestData
    {
        public static IEnumerable<Genre> CreateGenres()
        {
            return new Genre[]
            {
                new Genre()
                {
                    GenreId = 1,
                    Title = "Drama"
                },
                new Genre()
                {
                    GenreId = 2,
                    Title = "Comedy"
                },
                new Genre()
                {
                    GenreId = 3,
                    Title = "Action"
                }
            };
        }

        public static IEnumerable<Actor> CreateActors()
        {
            return new Actor[]
            {
                new Actor()
                {
                    ActorId = 1,
                    FirstName = "Allan",
                    LastName = "Carlos"
                }, 
                new Actor()
                {
                    ActorId = 2,
                    FirstName = "Intal",
                    LastName = "Roberto"
                },
                new Actor()
                {
                    ActorId = 3,
                    FirstName = "Norma",
                    LastName = "Garcia"
                },
                new Actor()
                {
                    ActorId = 4,
                    FirstName = "Archie",
                    LastName = "Carlos"
                },
                new Actor()
                {
                    ActorId = 5,
                    FirstName = "Kris",
                    LastName = "Cuyugan"
                }
            };
        }

        public static IEnumerable<Movie> CreateMovies()
        {
            var genres = CreateGenres();
            var actors = CreateActors();
            var items = new List<Movie>();

            items.Add(new Movie()
            {
                MovieId = 1,
                Title = "The Godfather",
                Genre = genres.FirstOrDefault(g => g.GenreId == 1),
                Actors = new Actor[]
                {
                    actors.FirstOrDefault(g => g.ActorId == 1),
                }
            });

            items.Add(new Movie()
            {
                MovieId = 2,
                Title = "The Shawshank Redemption",
                Genre = genres.FirstOrDefault(g => g.GenreId == 2),
                Actors = new Actor[]
                {
                    actors.FirstOrDefault(g => g.ActorId == 2),
                    actors.FirstOrDefault(g => g.ActorId == 3)
                }
            });

            items.Add(new Movie()
            {
                MovieId = 3,
                Title = "The Dark Knight",
                Genre = genres.FirstOrDefault(g => g.GenreId == 3),
                Actors = new Actor[]
                {
                    actors.FirstOrDefault(g => g.ActorId == 5),
                    actors.FirstOrDefault(g => g.ActorId == 4)
                }
            });

            items.Add(new Movie()
            {
                MovieId = 4,
                Title = "Pulp Fiction",
                Genre = genres.FirstOrDefault(g => g.GenreId == 1),
                Actors = new Actor[]
                {
                    actors.FirstOrDefault(g => g.ActorId == 5)
                }
            });

            items.Add(new Movie()
            {
                MovieId = 5,
                Title = "Fight Club",
                Genre = genres.FirstOrDefault(g => g.GenreId == 3),
                Actors = new Actor[]
                {
                    actors.FirstOrDefault(g => g.ActorId == 2)
                }
            });

            return items;
        }
    }
}