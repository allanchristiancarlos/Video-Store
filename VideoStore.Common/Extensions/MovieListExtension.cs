using System;
using System.Collections.Generic;
using System.Linq;
using VideoStore.Common.Models;

namespace VideoStore.Common.Extensions
{
    public static class MovieListExtension
    {
        public static IEnumerable<Movie> WhereTitle(this IEnumerable<Movie> data, string title)
        {
            foreach (var item in data)
            {
                if (item.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    yield return item;
                }
            }    
        }

        public static IEnumerable<Movie> WhereActor(this IEnumerable<Movie> data, int actorId)
        {
            foreach (var item in data)
            {
                if (item.Actors.Any(a => a.ActorId == actorId))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<Movie> WhereGenre(this IEnumerable<Movie> data, int genreId)
        {
            foreach (var item in data)
            {
                if (item.Genre.GenreId == genreId)
                {
                    yield return item;
                }
            }
        }
    }
}
