using KinoDom.API.Enums;

namespace KinoDom.API.Data.DTOs.User
{
    public class UpdateUserDto
    {
        public string Username { get; set; }
        public string AvatarUrl { get; set; }
        public UserRole UserRole { get; set; }
    }
}
