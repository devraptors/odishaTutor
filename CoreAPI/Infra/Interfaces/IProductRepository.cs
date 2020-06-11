using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
   public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<Product>> GetProductAsync();
    }
}
