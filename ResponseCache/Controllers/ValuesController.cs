using Microsoft.AspNetCore.Mvc;

namespace ResponseCache.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase  
{

    [HttpGet]
    public int Get()
    {
        return DateTime.Now.Second;
    }
}
