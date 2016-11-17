using System.Data.Entity;
using VideoStore.Common.Models;

namespace VideoStore.Client
{
    public class VideoStoreContext : DbContext
    {
        static VideoStoreContext()
        {
            Database.SetInitializer<VideoStoreContext>(null);
        }

        public VideoStoreContext()
            : base("name=DefaultConnection")
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }
        public DbSet<Dvd> Dvds { get; set; }
    }
}
