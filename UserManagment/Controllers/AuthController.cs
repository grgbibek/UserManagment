using Microsoft.AspNetCore.Mvc;
using UserManagment.Data.Entities;
using UserManagment.Helpers;

namespace UserManagment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly TokenHelper _tokenHelper;

    public AuthController(TokenHelper tokenHelper)
    {
        _tokenHelper = tokenHelper;
    }

    [HttpGet("token/{username}")]
    public IActionResult GetToken(string username)
    {
        // For testing
        var token = _tokenHelper.GenerateToken(username);
        return Ok(new { Token = token });
    }
}
