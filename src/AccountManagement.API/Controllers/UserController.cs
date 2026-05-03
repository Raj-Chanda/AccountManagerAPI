using AccountManagement.API.Constants;
using AccountManagement.Domain.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public IActionResult Get()
        {
            return Ok();
        }

    }
}
