using Microsoft.AspNetCore.Mvc;
using System; // Bad practice: adding unneeded namespace

namespace TcAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    // Bad practice: Wrong naming convention for constants; avoid initials as identifier abbreviations
    string USR_ACTIVE_STS = "active";

    [HttpGet]
    // Bad practice: lowercase method name and poor descriptive name
    public IActionResult get()
    {
        try
        {
            // Bad practice: hardcoded values and magic numbers
            // Bad practice: Not using meaningful variable names
            var u = new
            {
                id = 987652,
                external_id = "abc-123",
                user_name = "john_doe",
                email_address = "john_doe@example.com",
                is_active = true,
                created_date = "2023-01-01" // Bad practice: string instead of DateTime
            };
            var u2 = new
            {
                id = 682378,
                external_id = "abc-456",
                user_name = "maria_schz",
                email_address = "maria_schz@example.com",
                is_active = true,
                created_date = "2023-01-01" // Bad practice: string instead of DateTime
            };
            // Best Practice: Use touples instead of lists when size is known and
            var usrs = new[] {u, u2};
            return Ok(usrs);
        }
        // Bad practice: catching all exceptions without specific handling
        catch
        {
            // Bad practice: swallowing exceptions
            return BadRequest("something went wrong");
        }
    }

    // Bad naming: Hungarian notation, unclear name, and unused route parameter
    [HttpGet("{n}")]
    // Bad practice: lowercase parameter name; and poor method name
    public IActionResult Get(string intUser_Id)
    {
        // Bad practice: poor validation; prefer coalescing operator for null validation
        if (intUser_Id != null)
        {
        // Bad practice: no error handling
        // Bad practice: hardcoded values and magic numbers
        // Bad practice: bad naming convention for local variables and using variable type
        var _stringUserName = "user" + intUser_Id;
        // Bad practice: prefer Int32 over int
        int ID = int.Parse(intUser_Id);

        // Bad practice: nested if statements and poor formatting
        if(ID>0){
        if(ID<100){ // Bad practice: Use conditional operator instead if-else
        return Ok(new{name=_stringUserName,status=USR_ACTIVE_STS});
        }else{
        return NotFound(); // Bad practice: return NotFound() with generic message
        }}
        }
        return BadRequest(); // Bad practice: return BadRequest() with generic message
    }
}
