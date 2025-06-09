using Microsoft.AspNetCore.Mvc;

namespace TcAPI;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "User endpoint working" });
    }
}