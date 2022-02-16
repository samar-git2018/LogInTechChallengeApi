using Microsoft.AspNetCore.Mvc;

namespace UserAuthentication.Controllers;

[ApiController]
[Route("[controller]")]
public class UserAuthenticationController : ControllerBase
{
   

    private readonly ILogger<UserAuthenticationController> _logger;

    public UserAuthenticationController(ILogger<UserAuthenticationController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = nameof(UserLogin))]
    public ActionResult<UserCreateDto>? UserLogin([FromBody] UserCreateDto userCreateDto)
    {
        if (userCreateDto == null)
        {
            return BadRequest();
        }
        if (userCreateDto.UserName == "Samar" && userCreateDto.PassWord == "pass123")
        {

            return Ok(userCreateDto);
        }
        else
        {
            return Ok(new { });
        }
    }


}

public class UserCreateDto
{
    public string UserName { get; set; }
    public string PassWord { get; set; }
}


