using System.Collections.Generic;
using VideoStore.Common.Models;

namespace VideoStore.Common.Contracts
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
    }
}