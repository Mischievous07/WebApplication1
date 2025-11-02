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
            // the Name
            var response = new { name = "Holden" };

            // Returns HTTP 200 with JSON: { "name": "Holden" }
            return Ok(response);
        }

    }
}

