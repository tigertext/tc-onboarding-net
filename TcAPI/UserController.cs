using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TcAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    string USR_ACTIVE_STS = "active";

    [HttpGet]
    public IActionResult get()
    {
        try
        {
            var u = new
            {
                id = 987652,
                external_id = "abc-123",
                user_name = "john_doe",
                email_address = "john_doe@example.com",
                is_active = true,
                created_date = "2023-01-01"
            };
            var u2 = new
            {
                id = 682378,
                external_id = "abc-456",
                user_name = "maria_schz",
                email_address = "maria_schz@example.com",
                is_active = true,
                created_date = "2023-01-01"
            };
            var usrs = new[] {u, u2};
            return Ok(usrs);
        }
        catch
        {
            return BadRequest("something went wrong");
        }
    }

    [HttpGet("{n}")]
    public IActionResult Get(string intUser_Id)
    {
        if (intUser_Id != null)
        {
        var _stringUserName = "user" + intUser_Id;
        int ID = int.Parse(intUser_Id);

        if(ID>0){
        if(ID<100){
        return Ok(new{name=_stringUserName,status=USR_ACTIVE_STS});
        }else{
        return NotFound();
        }}
        }
        return BadRequest();
    }
}
