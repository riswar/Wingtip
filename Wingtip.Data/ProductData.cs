using System;
using System.Collections.Generic;
using System.Text;
using Wingtip.Domain;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wingtip.Data
{
    public class ProductData : IProductData
    {
        private readonly IWingtopContext _wingtopContext;

        public ProductData(IWingtopContext wingtopContext)
        {
            this._wingtopContext = wingtopContext;
        }
        public async Task<IEnumerable<Product>> GetProductsByCarAsync(string searchName)
        {
            return await (from prd in _wingtopContext.Products where (prd.CategoryId== 1 && prd.ProductName.Contains(searchName)) || prd.CategoryId == 1 && string.IsNullOrEmpty(searchName) select prd).ToListAsync();
        }
    }
}
