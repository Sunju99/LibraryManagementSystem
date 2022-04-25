using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;
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
    public class SupplierController : ControllerBase
    {
        private readonly ISupplier _iSupplier;

        public SupplierController(ISupplier supplier)
        {
            _iSupplier = supplier;
        }
        // GET: api/<SupplierController>
        [HttpGet]
        public async Task<IEnumerable<Supplier>> Get()
        {
            return await _iSupplier.GetSuppliers();
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Supplier supplier = await _iSupplier.GetSupplier(id);
            if(supplier==null)
            {
                return NotFound("Not found the Supplier");
            }
            return Ok(supplier);
        }

        // POST api/<SupplierController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Supplier supplier)
        {
            await _iSupplier.AddSupplier(supplier);
            return Ok("Successfully add supplier");
        }

        // PUT api/<SupplierController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Supplier supplier)
        {
            Supplier suplier = await _iSupplier.UpdateSupplierDetail(supplier);
            if(supplier==null)
            {
                return NotFound("Supplier is not found");
            }
            return Ok(suplier);
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _iSupplier.DeleteSupplier(id);
            return Ok("Successfully delete supplier");
        }
    }
}
