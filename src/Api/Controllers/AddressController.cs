using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Request.RiderAddress;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/rider/[controller]")]
    public class AddressController : ControllerBase
    {
        
        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] List<CreateRiderAddressRequest> request) 
        {
            return await Task.FromResult(Ok());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            [FromQuery] string id,
            [FromBody] UpdateRiderAddressRequest request)
        {
            return await Task.FromResult(Ok());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            return await Task.FromResult(Ok());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromRoute] string id)
        {
            return await Task.FromResult(Ok());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress([FromRoute] string id)
        {
            return await Task.FromResult(Ok());
        }

    }
}