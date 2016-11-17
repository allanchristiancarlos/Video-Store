using System.Collections.Generic;

namespace VideoStore.Common.Models
{
    public class Actor
    {
        public Actor()
        {
            this.Movies = new HashSet<Movie>();
        }
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}