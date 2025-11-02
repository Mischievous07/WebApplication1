using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        // GET api/name
        [HttpGet]
        public ActionResult<object> Get()
        {
            // Replace "Alice" with any name you want to return
            var response = new { name = "Holden" };

            // Returns HTTP 200 with JSON: { "name": "Alice" }
            return Ok(response);
        }

    }
}

