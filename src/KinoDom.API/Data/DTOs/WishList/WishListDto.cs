namespace KinoDom.API.Data.DTOs.WishList
{
    public class WishListDto
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
