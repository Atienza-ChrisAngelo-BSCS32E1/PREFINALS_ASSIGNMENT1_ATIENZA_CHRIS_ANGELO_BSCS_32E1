using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        var userClaims = User.Claims.Select(c => new { c.Type, c.Value });
        // Return user information and fun facts about API creator
        return Ok(new
        {
            User = new { Name = "Chris", Section = "BSCS-32E1", Course = "ComSci" },
            FunFacts = new string[]
            {
                "I love gaming!",
                "I enjoy listening to music.",
                "I'm an introvert."
            }
        });
    }
}
