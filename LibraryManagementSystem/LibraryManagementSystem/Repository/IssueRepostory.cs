using LibraryManagementSystem.DBContext;
using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repository
{
    public class IssueRepostory : IIssue
    {
        private readonly LibraryDBContext _libraryDBContext;

        public IssueRepostory(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public async Task AddIssue(Issue issue)
        {
            await _libraryDBContext.Issues.AddAsync(issue);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteIssue(int issueId)
        {
            Issue issue = new Issue()
            {
                IssueId = issueId
            };
            _libraryDBContext.Issues.Remove(issue);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task<Issue> GetIssue(int issueId)
        {
            return await _libraryDBContext.Issues.FindAsync(issueId);
        }

        public async Task<IEnumerable<Issue>> GetIssues()
        {
            return await _libraryDBContext.Issues.ToListAsync();
        }

        public async Task<Issue> UpdateIssue(Issue issue)
        {
            _libraryDBContext.Issues.Update(issue);
            await _libraryDBContext.SaveChangesAsync();
            return issue;
        }
    }
}
