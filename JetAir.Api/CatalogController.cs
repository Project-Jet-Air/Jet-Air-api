using Microsoft.AspNetCore.Mvc;
using JetAir.Domain.Catalog;

namespace JetAir.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
       [HttpGet]
public IActionResult GetItems()
{
    var items = new List<Item>()
    {
        new Item(1, "Shirt", "Ohio State shirt.", "Nike", 29.99m),
        new Item(2, "Shorts", "Ohio State shorts.", "Nike", 44.99m)
    };

    return Ok(items);
}

    }
}
