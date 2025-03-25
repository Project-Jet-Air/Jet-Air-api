using Microsoft.AspNetCore.Mvc;
using JetAir.Domain.Catalog;
using JetAir.Data;

namespace JetAir.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _context;

        public CatalogController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_context.Items.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            // For now, simulate getting an item by ID
            var item = new Item { ItemId = id, Name = $"Item {id}", Description = "Simulated Item", Price = 10.00m };
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult PostItem([FromBody] Item item)
        {
            return CreatedAtAction(nameof(GetItem), new { id = item.ItemId }, item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating)
        {
            return Ok($"Rating added to item {id}");
        }

        [HttpPut("{id:int}")]
        public IActionResult PutItem(int id, [FromBody] Item item)
        {
            return Ok($"Item {id} updated");
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteItem(int id)
        {
            return Ok($"Item {id} deleted");
        }
    }
}