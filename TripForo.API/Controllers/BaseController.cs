using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TripForo.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
        }
    }
}
