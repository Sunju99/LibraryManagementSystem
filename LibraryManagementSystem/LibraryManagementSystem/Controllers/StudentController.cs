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
    public class StudentController : ControllerBase
    {
        private readonly IStudent _iStudent;
        public StudentController(IStudent student)
        {
            _iStudent = student;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IEnumerable<Student>>  Get()
        {
            return await _iStudent.GetStudents();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Student student = await _iStudent.GetStudent(id);
            if (student == null)
            {
                return NotFound("Not found the student");
            }
            return Ok(student);
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student student)
        {
            await _iStudent.AddStudent(student);
            return Ok("Successfully add student");
        }

        // PUT api/<StudentController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Student student)
        {
            Student student1 = await _iStudent.UpdateStudent(student);
            if (student1 == null)
            {
                return NotFound("Not found the student");
            }
            return Ok(student1);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _iStudent.DeleteStudent(id);
            return Ok("Successfully delete student");
        }
    }
}
