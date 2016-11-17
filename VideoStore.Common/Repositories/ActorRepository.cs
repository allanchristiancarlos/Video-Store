using System;
using System.Collections.Generic;
using VideoStore.Common.Contracts;
using VideoStore.Common.Models;

namespace VideoStore.Common.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly IEnumerable<Actor> _actors;

        public ActorRepository(IEnumerable<Actor> actors)
        {
            _actors = actors;
        }

        public IEnumerable<Actor> GetActors()
        {
            return _actors;
        }
    }
}