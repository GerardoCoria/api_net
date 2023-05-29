using Microsoft.AspNetCore.Mvc;

namespace api_net.Controllers;

[ApiController]
[Route("[controller]")]

public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloWorldService;

    public HelloWorldController(IHelloWorldService helloWorld)
    {
        helloWorldService = helloWorld;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(helloWorldService.GetHelloWorld());
    }
}