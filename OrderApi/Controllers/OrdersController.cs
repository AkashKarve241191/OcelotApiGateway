using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Model;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public IActionResult Get()
        {
            var order1 = new Order("ID001", 200);
            var order2 = new Order("ID002", 400);

            var orders = new List<Order> { order1, order2 };

            return Ok(orders);
        }
    }
}
