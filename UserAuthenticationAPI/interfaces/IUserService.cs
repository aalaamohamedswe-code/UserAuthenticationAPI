using UserAuthenticationAPI.DTOs;

public interface IUserService
{
    IEnumerable<UserDto> GetAllUsers();
}
