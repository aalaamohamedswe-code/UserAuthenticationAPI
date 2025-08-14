using UserAuthenticationAPI.Models;
using UserAuthenticationAPI.DTOs;

public interface IAuthService
{
    User Register(RegisterDto request);
    string Login(LoginDto request);
}
