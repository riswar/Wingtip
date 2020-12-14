using System.Collections.Generic;
using System.Threading.Tasks;
using Wingtip.Domain;

namespace Wingtip.Data
{
    public interface IProductData
    {
        Task<IEnumerable<Product>> GetProductsByCarAsync(string searchName);
    }
}