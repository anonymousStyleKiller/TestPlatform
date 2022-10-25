using Microsoft.AspNetCore.Mvc;

namespace TestPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult Get(string id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Put()
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        return Ok(id);
    }
}