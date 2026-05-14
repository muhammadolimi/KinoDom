using KinoDom.API.Enums;

namespace KinoDom.API.Data.DTOs.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public String Username { get; set; }
        public String Email { get; set; }
        public String AvatarUrl { get; set; }
        public UserRole UserRole { get; set; }
    }
}
