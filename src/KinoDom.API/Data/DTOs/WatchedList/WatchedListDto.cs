namespace KinoDom.API.Data.DTOs.WatchList
{
    public class WatchedListDto
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
