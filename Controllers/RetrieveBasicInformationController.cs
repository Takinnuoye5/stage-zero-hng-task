using Microsoft.AspNetCore.Mvc;

namespace HNG_STAGE_ZERO_TASK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetrieveBasicInformationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var response = new
            {
                email = "akinnuoyet@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                github_url = "https://github.com/Takinnuoye5/stage-zero-hng-task"
            };

            return Ok(response);
        }
    }
    
}