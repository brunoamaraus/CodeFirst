using Microsoft.AspNetCore.Mvc;

namespace N1CoreProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Status")]
    public class StatusController : Controller
    {
        [HttpGet]
        public string GetStatus()
        {
            return "API OnLine";
        }
    }
}