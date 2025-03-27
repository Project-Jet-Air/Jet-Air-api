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
           var item = _context.Items.Find(id);
            if (item == null)
        {
            return NotFound();
        }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return Created($"/catalog/{item.Id}", item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating)
        {
            var item = _contextItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            item.AddRating(rating);
            _context.SaveChanges();

            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public IActionResult PutItem(int id, [FromBody] Item item)
        {
            if (id != item.Id)
        {
            return BadRequest();
        }

        if (_context.Items.Find(id) == null)
        {
            return NotFound();
        }

        _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();

        return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _context.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            _context.SaveChanges();

            return Ok();
    }
    }