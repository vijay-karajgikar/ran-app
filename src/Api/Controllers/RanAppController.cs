using Microsoft.AspNetCore.Mvc;
using RanApp.Models.Request;

namespace RanApp.Api.Controllers
{
    [ApiController]
    [Route("api/ran/[controller]")]
    public class RanAppController : ControllerBase
    {
        [HttpPost("appointments")]
        public async Task<IActionResult> CreateAppointment(
            [FromBody] CreateAppointmentRequest request)
        {
            return await Task.FromResult(Ok());
        }

    }
}