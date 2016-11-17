using System.Collections.Generic;
using VideoStore.Common.Models;

namespace VideoStore.Common.Contracts
{
    public interface IActorRepository
    {
        IEnumerable<Actor> GetActors();
    }
}