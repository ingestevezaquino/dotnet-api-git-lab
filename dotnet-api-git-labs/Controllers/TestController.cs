using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_api_git_labs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {
            
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Test funciona correctamente!");
        }

        [HttpGet]
        [Route("GetRociosLove")]
        public IActionResult GetRocio()
        {
            return Ok("Obtener el amor de Rocio!");
        }
    }
}
