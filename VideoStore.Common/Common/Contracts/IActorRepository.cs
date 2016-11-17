using System.Collections.Generic;
using VideoStore.Models;

namespace VideoStore.Common.Contracts
{
    public interface IActorRepository
    {
        IEnumerable<Actor> GetActors();
    }
}