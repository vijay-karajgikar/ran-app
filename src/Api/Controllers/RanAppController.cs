using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RanApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RanAppController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.FromResult(Ok(new {
                message = "Hello World"
            }));
        }
    }
}