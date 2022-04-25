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
    public class BookStatusController : ControllerBase
    {
        private readonly IBookStatus _bookStatus;

        public BookStatusController(IBookStatus bookStatus)
        {
            _bookStatus = bookStatus;
        }
        // GET: api/<BookStatusController>
        [HttpGet]
        public async Task<IEnumerable<BookStatus>> Get()
        {
            return await _bookStatus.GetBookStatus();
        }

        // GET api/<BookStatusController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            BookStatus bookStatus = await _bookStatus.GetBookStatus(id);
            if (bookStatus == null)
            {
                return NotFound("Not found the bookStatus");
            }
            return Ok(bookStatus);
        }

        // POST api/<BookStatusController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BookStatus bookStatus)
        {
            await _bookStatus.AddBookStatus(bookStatus);
            return Ok("Successfully add bookStatus");
        }

        // PUT api/<BookStatusController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] BookStatus bookStatus)
        {
            BookStatus bookStatus1 = await _bookStatus.UpdateBookStatus(bookStatus);
            if (bookStatus1 == null)
            {
                return NotFound("Not found the bookStatus");
            }
            return Ok(bookStatus1);
        }

        // DELETE api/<BookStatusController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookStatus.DeleteBookStatus(id);
            return Ok("Successfully delete bookStatus");
        }
    }
}
