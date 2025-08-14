using UserAuthenticationAPI.DTOs;
using UserAuthenticationAPI.interfaces;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<UserDto> GetAllUsers()
    {
        var users = _userRepository.GetAll();
        return users.Select(u => new UserDto { Id = u.Id, Username = u.Username, Role = u.Role });
    }

}
