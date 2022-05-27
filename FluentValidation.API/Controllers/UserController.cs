using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserManager userManager;

    public UserController(IUserManager userManager)
    {
        this.userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Get(string name, string address)
    {
        await userManager.Manage(new User
        {
            Name = name,
            Address = address
        });
        return Ok();
    }
}
