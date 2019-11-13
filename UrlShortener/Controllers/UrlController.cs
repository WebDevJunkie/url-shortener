using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var urls = new List<object>()
            {
                new { Redirect = "http://www.google.com", Description = "Description" }
            };

            return Ok(urls);
        }
    }
}
