using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<bool> AddProduct([FromBody] Products product) 
        {
            try
            {
                await _context.ProductTable.AddAsync(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e) 
            {
                return false;
            }
        }


    }
}
