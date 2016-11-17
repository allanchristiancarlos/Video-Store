using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStore.Common.Contracts;
using VideoStore.Common.Extensions;
using VideoStore.Common.Repositories;

namespace VideoStore.Tests
{
    [TestClass]
    public class MovieBrowsingTests
    {
        private IMovieRepository _repository;

        [TestInitialize]
        public void Setup()
        {
            _repository = new MovieRepository(TestData.CreateMovies());
        }

        [TestMethod]
        public void Should_search_movie_by_title()
        {
            Assert.IsNotNull(_repository.GetMovies()
                .WhereTitle("Godfather")
                .FirstOrDefault());
        }

        [TestMethod]
        public void Should_search_movie_ignoring_the_case_sensitivity()
        {
            Assert.IsNotNull(_repository.GetMovies()
                .WhereTitle("godfather")
                .FirstOrDefault());
        }

        [TestMethod]
        public void Should_get_the_actors_of_the_movie()
        {
            var movie = _repository.GetMovies().FirstOrDefault();

            Assert.AreEqual(1, movie?.Actors.Count);
        }
    }
}
