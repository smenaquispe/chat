using MessageProject.Models;
using MessageProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessageProject.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(_userService.GetUsers());
    }

    [HttpPost]
    public IActionResult PostUser([FromBody] UserModel user)
    {
        if(string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            return BadRequest("Username and Password are required.");

        _userService.AddUser(user);
        return CreatedAtAction(nameof(GetUsers), new {id = user.Id}, user);
    }
}