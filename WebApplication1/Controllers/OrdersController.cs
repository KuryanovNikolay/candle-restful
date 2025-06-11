using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers;

[ApiController]
[Route("orders")]
public class OrdersController : ControllerBase
{
    private List<Order> _orders = new List<Order>
    {
        new Order(1, "Order 1"),
        new Order(2, "Order 2")
    };

    [HttpGet]
    public IActionResult GetOrderById([FromQuery]int id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        return Ok(order);
    }

}
