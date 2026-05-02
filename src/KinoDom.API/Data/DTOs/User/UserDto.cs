using KinoDom.API.Enums;

namespace KinoDom.API.Data.DTOs.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
        public UserRole UserRole { get; set; }
    }
}
