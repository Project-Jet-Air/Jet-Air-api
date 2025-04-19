using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
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
        new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
        new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m)
    };

    return Ok(items);
}

[HttpDelete("{id:int}")]
[Authorize("delete:catalog")]
public IActionResult Delete(int id)
{
    return NoContent();
}
}
}
