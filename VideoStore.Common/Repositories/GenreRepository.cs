using System.Collections.Generic;
using VideoStore.Common.Contracts;
using VideoStore.Common.Models;

namespace VideoStore.Common.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IEnumerable<Genre> _genres;

        public GenreRepository(IEnumerable<Genre> genres)
        {
            _genres = genres;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _genres;
        }
    }
}