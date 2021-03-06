using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
 using Infra;

namespace OdishaAPP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class _ProductController :ControllerBase
    {
        private readonly IProductRepository _repo;
        public _ProductController(IProductRepository repo )
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _repo.GetProductAsync();

            return Ok(products);

        }
        [HttpGet("{id}")]
         public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _repo.GetProductByIdAsync(id);
            
        }

    }
}