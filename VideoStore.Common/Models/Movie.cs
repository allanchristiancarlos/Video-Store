using System.Collections.Generic;

namespace VideoStore.Common.Models
{
    public class Movie
    {
        public Movie()
        {
            this.Actors = new HashSet<Actor>();
        }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Dvd> Dvds { get; set; }
    }
}