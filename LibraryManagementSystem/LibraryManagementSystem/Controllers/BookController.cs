using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _book;

        public BookController(IBook book)
        {
            _book = book;
        }
        // GET: api/<EBookController>
        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
            return await _book.GetBookAsync();
        }

        // GET api/<EBookController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Book book = await _book.GetBook(id);
            if (book == null)
            {
                return NotFound("Not found the Book");
            }
            return Ok(book);
        }

        // POST api/<EBookController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Book book)
        {
            await _book.AddBook(book);
            return Ok(book);
        }

        // PUT api/<EBookController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Book book)
        {
            Book book1 = await _book.UpdateBookAsync(book);
            if (book1 == null)
            {
                return NotFound("Not found the Book");
            }
            return Ok(book1);
        }

        // DELETE api/<EBookController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _book.DeleteBookAsync(id);
            return Ok("Successfully delete Book");
        }
    }
}
