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

        // Navigation property for the one-to-many relationship with Review
        public ICollection<Review> Reviews { get; set; }
    }
}