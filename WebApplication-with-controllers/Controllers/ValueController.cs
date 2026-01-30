using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_with_controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {

        [HttpGet(Name = "GetValue")]
        public int Get()
        {
            return 42;
            // return Enumerable.Range(1, 5).Count();
        }
    }
}
