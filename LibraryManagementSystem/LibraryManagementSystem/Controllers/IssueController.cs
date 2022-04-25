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
    public class IssueController : ControllerBase
    {
        private readonly IIssue _issue;

        public IssueController(IIssue issue)
        {
            _issue = issue;
        }
        // GET: api/<IssueController>
        [HttpGet]
        public async Task<IEnumerable<Issue>>  Get()
        {
            return await _issue.GetIssues();
        }

        // GET api/<IssueController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Issue issue = await _issue.GetIssue(id);
            if (issue == null)
            {
                return NotFound("Not found the Issue");
            }
            return Ok(issue);
        }

        // POST api/<IssueController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Issue issue)
        {
            await _issue.AddIssue(issue);
            return Ok("Successfully add issue");
        }

        // PUT api/<IssueController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Issue issue)
        {
            Issue issue1 = await _issue.UpdateIssue(issue);
            if (issue1 == null)
            {
                return NotFound("Not found the Issue");
            }
            return Ok(issue1);
        }

        // DELETE api/<IssueController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _issue.DeleteIssue(id);
            return Ok("Successfully delete issue");
        }
    }
}
