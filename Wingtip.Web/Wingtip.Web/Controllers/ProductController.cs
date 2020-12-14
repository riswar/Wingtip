using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wingtip.Data;
using Wingtip.Domain;
using Wingtip.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wingtip.Web.Controllers
{

    public class ProductController : BaseController
    {
        private readonly ILogger _logger;
        private readonly IProductData _productData;
        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, IProductData productData, IMapper mapper)
        {
            this._logger = logger;
            this._productData = productData;
            this._mapper = mapper;
        }
        //// GET: api/<ProductController>
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ProductViewModel>>> Get()
        //{
        //    var result = await Get(string.Empty);
        //    return result;
        //}
        // GET: api/<ProductController>
        [HttpGet]        
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> Get()
        {
            string searchName = string.Empty;
            _logger.LogInformation($"Entering into GetProduct arguments : {searchName}");
            var result = await _productData.GetProductsByCarAsync(searchName);
            var mapperresult = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(result);
            _logger.LogInformation($"Leaving from GetProduct : # of rows : {mapperresult.Count()}");
            return Ok(mapperresult);
        }
    }
}
