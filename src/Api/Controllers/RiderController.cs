using Microsoft.AspNetCore.Mvc;
using Models.Request.Rider;
using RanApp.Models.Request.Rider;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RiderController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllRiders()
        {
            return await Task.FromResult(Ok("getallriders"));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRiderById(
            [FromRoute] string id)
        {
            return await Task.FromResult(Ok(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRider(
            [FromBody] CreateRiderRequest request)
        {
            return await Task.FromResult(Ok(request));
        }

        [HttpPost("search")]
        public async Task<IActionResult> Search(
            [FromBody] SearchRiderRequest request)
        {
            return await Task.FromResult(Ok(request));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRider(
            [FromRoute] string id, 
            [FromBody] UpdateRiderRequest request)
        {
            return await Task.FromResult(Ok(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRider(
            [FromRoute] string id)
        {
            return await Task.FromResult(Ok(id));
        }
    }
}