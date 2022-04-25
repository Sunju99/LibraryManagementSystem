using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface IIssue
    {
        Task<IEnumerable<Issue>> GetIssues();
        Task<Issue> GetIssue(int issueId);
        Task AddIssue(Issue issue);
        Task<Issue> UpdateIssue(Issue issue);
        Task DeleteIssue(int issueId);
    }
}
