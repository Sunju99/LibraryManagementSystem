using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementSystem.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISale _iSale;

        public SaleController(ISale sale)
        {
            _iSale = sale;
        }
        // GET: api/<SaleController>
        [HttpGet]
        public async Task<IEnumerable<Sale>> Get()
        {
            return await _iSale.GetSales();
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Sale sale = await _iSale.Getsale(id);
            if (sale == null)
            {
                return NotFound("Not found the Sale");
            }
            return Ok(sale);
        }

        // POST api/<SaleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Sale sale)
        {
            await _iSale.Addsale(sale);
            return Ok("Successfully add Sale");
        }

        // PUT api/<SaleController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Sale sale)
        {
            Sale sale1 = await _iSale.UpdateSale(sale);
            if (sale1 == null)
            {
                return NotFound("Sale is not found");
            }
            return Ok(sale1);
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _iSale.DeleteSale(id);
            return Ok("Successfully delete Sale");
        }
    }
}
