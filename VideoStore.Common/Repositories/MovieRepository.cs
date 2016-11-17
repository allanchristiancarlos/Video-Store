using System.Collections.Generic;
using VideoStore.Common.Contracts;
using VideoStore.Common.Models;

namespace VideoStore.Common.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IEnumerable<Movie> _videos;

        public MovieRepository(IEnumerable<Movie> videos)
        {
            _videos = videos;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _videos;
        }
    }
}