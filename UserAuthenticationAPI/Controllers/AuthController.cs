using Microsoft.AspNetCore.Mvc;
using UserAuthenticationAPI.DTOs;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService){
        _authService = authService;
    }
    [HttpPost("register")]
    public IActionResult Register(RegisterDto request){
        var user = _authService.Register(request);
        return Ok(user);
    }
    [HttpPost("login")]
    public IActionResult Login(LoginDto request){
        var token = _authService.Login(request);
        if (token == null)
        {
            return Unauthorized("Invalid credentials.");
        }
        return Ok(new { Token = token });
    }
}
