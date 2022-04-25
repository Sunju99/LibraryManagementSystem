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
    public class FacultyController : ControllerBase
    {
        private readonly IFaculty _faculty;

        public FacultyController(IFaculty faculty)
        {
            _faculty = faculty;
        }
        // GET: api/<FacultyController>
        [HttpGet]
        public async Task<IEnumerable<Faculty>> Get()
        {
            return await _faculty.GetFacultys();
        }
        // GET api/<FacultyController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Faculty faculty = await _faculty.GetFaculty(id);
            if (faculty == null)
            {
                return NotFound("Not found the faculty");
            }
            return Ok(faculty);
        }

        // POST api/<FacultyController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Faculty faculty)
        {
            await _faculty.AddFaculty(faculty);
            return Ok("Successfully add faculty");
        }

        // PUT api/<FacultyController>/5
        [HttpPut]
        public async Task<IActionResult> Put( [FromBody] Faculty faculty)
        {
            Faculty faculty1 = await _faculty.UpdateFaculty(faculty);
            if (faculty1 == null)
            {
                return NotFound("Not found the faculty");
            }
            return Ok(faculty1);
        }

        // DELETE api/<FacultyController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _faculty.DeleteFaculty(id);
            return Ok("Successfully delete faculty");
        }
    }
}
