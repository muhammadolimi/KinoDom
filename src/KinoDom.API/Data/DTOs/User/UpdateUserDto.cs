using KinoDom.API.Enums;

namespace KinoDom.API.Data.DTOs.User
{
    public class UpdateUserDto
    {
        public String Username { get; set; }
        public String AvatarUrl { get; set; }
        public UserRole UserRole { get; set; }
    }
}
