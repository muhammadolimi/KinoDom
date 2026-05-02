using KinoDom.API.Enums;

namespace KinoDom.API.Data.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }     
        public string Email { get; set; }  
        public string PasswordHash { get; set; }  
        public string AvatarUrl { get; set; } = "https://www.gravatar.com/avatar/";
        public UserRole UserRole { get; set; } = UserRole.User;

        // navigation properties
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<WatchedList> WishList { get; set; } = [];
        public ICollection<WatchedList> WatchedList { get; set; } = [];

    }
}