using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingCoffee.Server;
using BlazingCoffee.Shared.Models;
using Telerik.DataSource;
using Telerik.DataSource.Extensions;

namespace BlazingCoffee.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly CoffeeContext _context;

        public SalesController(CoffeeContext context)
        {
            _context = context;
        }

        // GET: api/Sales
        [HttpPost]
        public async Task<ActionResult<DataSourceResult>> GetSales([FromBody]DataSourceRequest request)
        {
            var result = await _context.Sales.ToDataSourceResultAsync(request);
            return result;
        }

        // GET: api/Sales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSale(int id)
        {
            var sale = await _context.Sales.FindAsync(id);

            if (sale == null)
            {
                return NotFound();
            }

            return sale;
        }


        private bool SaleExists(int id)
        {
            return _context.Sales.Any(e => e.Id == id);
        }
    }
}
