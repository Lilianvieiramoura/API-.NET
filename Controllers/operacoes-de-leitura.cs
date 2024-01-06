using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloworldController : Controller
{
  [HttpGet]
  public string Get() => "Hello world!";
}