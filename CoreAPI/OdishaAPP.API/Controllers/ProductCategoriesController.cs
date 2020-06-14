using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infra.Entities;
using OdishaAPP.API;

namespace OdishaAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductCategoriesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ProductCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductCategories>>> GetProductCategorey()
        {
            return await _context.ProductCategories.ToListAsync();
        }

        // GET: api/ProductCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductCategories>> GetProductCategories(int id)
        {
            var productCategories = await _context.ProductCategories.FindAsync(id);

            if (productCategories == null)
            {
                return NotFound();
            }

            return productCategories;
        }

        // PUT: api/ProductCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductCategories(int id, ProductCategories productCategories)
        {
            if (id != productCategories.Id)
            {
                return BadRequest();
            }

            _context.Entry(productCategories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCategoriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProductCategories>> PostProductCategories(ProductCategories productCategories)
        {
            _context.ProductCategories.Add(productCategories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductCategories", new { id = productCategories.Id }, productCategories);
        }

        // DELETE: api/ProductCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductCategories>> DeleteProductCategories(int id)
        {
            var productCategories = await _context.ProductCategories.FindAsync(id);
            if (productCategories == null)
            {
                return NotFound();
            }

            _context.ProductCategories.Remove(productCategories);
            await _context.SaveChangesAsync();

            return productCategories;
        }

        private bool ProductCategoriesExists(int id)
        {
            return _context.ProductCategories.Any(e => e.Id == id);
        }
    }
}
