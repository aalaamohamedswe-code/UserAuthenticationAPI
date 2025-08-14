using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpGet]
    [Authorize(Roles = "Admin")] 
    public IActionResult GetUsers()
    {
        var users = _userService.GetAllUsers(); 
        return Ok(users);
    }
}
