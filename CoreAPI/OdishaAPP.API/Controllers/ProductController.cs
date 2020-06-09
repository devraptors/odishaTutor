using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OdishaAPP.API.Data;
using OdishaAPP.API.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OdishaAPP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController :ControllerBase
    {
        private readonly DataContext _context;
        public ProductController(DataContext context)
        {
            _context=context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products=await _context.Products.ToListAsync();

            return Ok(products);

        }
        [HttpGet("{id}")]
         public async Task<ActionResult<Product>> GetProduct(int id)
        {
           return await _context.Products.FindAsync(id);
            
        }

    }
}