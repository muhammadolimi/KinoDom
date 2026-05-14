using KinoDom.API.Enums;

namespace KinoDom.API.Data.Models
{
    public class User : BaseEntity
    {
        public String Username { get; set; }     
        public String Email { get; set; }  
        public String PasswordHash { get; set; }  
        public String AvatarUrl { get; set; } = "https://www.gravatar.com/avatar/";
        public UserRole UserRole { get; set; } = UserRole.User;

        // navigation properties
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<WishList> WishLists { get; set; } = [];
        public ICollection<WatchedList> WatchedLists { get; set; } = [];

    }
}