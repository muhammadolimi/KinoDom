using KinoDom.API.Data.DTOs.User;
using KinoDom.API.Data.Models;
using KinoDom.API.Enums;

namespace KinoDom.API.Mappers;

public static class UserMapper
{
    public static UserDto ToDto(this User user)
    {
        return new UserDto
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            AvatarUrl = user.AvatarUrl,
            UserRole = user.UserRole
        };
    }

    public static User ToEntity(this CreateUserDto dto, string passwordHash)
    {
        return new User
        {
            Username = dto.Username,
            Email = dto.Email,
            PasswordHash = passwordHash,
            AvatarUrl = null,
            UserRole = UserRole.User
        };
    }

    public static User ToEntity(this UpdateUserDto dto)
    {
        return new User
        {
            Username = dto.Username,
            AvatarUrl = dto.AvatarUrl,
            UserRole = dto.UserRole
        };
    }
}