using System.Collections.Generic;

namespace VideoStore.Common.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Movies = new HashSet<Movie>();
        }

        public int GenreId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}