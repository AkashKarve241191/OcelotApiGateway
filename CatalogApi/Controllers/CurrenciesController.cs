using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            var currencies = new List<string> { "usd", "inr", "jsp" };
            return Ok(currencies);
        }
    }
}
