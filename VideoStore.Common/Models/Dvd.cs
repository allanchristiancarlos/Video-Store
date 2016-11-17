namespace VideoStore.Common.Models
{
    public class Dvd
    {
        public int DvdId { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public bool IsAvailable { get; set; }
    }
}