using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infra;
using OdishaAPP.API;

namespace OdishaAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductBandsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductBandsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ProductBands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductBand>>> GetProductBands()
        {
            return await _context.ProductBands.ToListAsync();
        }

        // GET: api/ProductBands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductBand>> GetProductBand(int id)
        {
            var productBand = await _context.ProductBands.FindAsync(id);

            if (productBand == null)
            {
                return NotFound();
            }

            return productBand;
        }

        // PUT: api/ProductBands/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductBand(int id, ProductBand productBand)
        {
            if (id != productBand.Id)
            {
                return BadRequest();
            }

            _context.Entry(productBand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductBandExists(id))
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

        // POST: api/ProductBands
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProductBand>> PostProductBand(ProductBand productBand)
        {
            _context.ProductBands.Add(productBand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductBand", new { id = productBand.Id }, productBand);
        }

        // DELETE: api/ProductBands/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductBand>> DeleteProductBand(int id)
        {
            var productBand = await _context.ProductBands.FindAsync(id);
            if (productBand == null)
            {
                return NotFound();
            }

            _context.ProductBands.Remove(productBand);
            await _context.SaveChangesAsync();

            return productBand;
        }

        private bool ProductBandExists(int id)
        {
            return _context.ProductBands.Any(e => e.Id == id);
        }
    }
}
