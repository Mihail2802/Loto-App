using Loto3000App.DTOs.UserDto;
using Loto3000App_Domain.Models;
using System.Runtime.CompilerServices;

namespace Loto3000App.Mappers
{
    public static class UserMapper
    {
        public static UserDto MapToUserDto(this User user)
        {
            return new UserDto()
            {
                Age = user.Age,
                Firstname = user.FirstName,
                Lastname = user.Lastname,
                Username = user.UserName,
            };
        }
    }
}
