using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface IFaculty
    {
        Task<IEnumerable<Faculty>> GetFacultys();
        Task<Faculty> GetFaculty(string facultyId);
        Task AddFaculty(Faculty faculty);
        Task<Faculty> UpdateFaculty(Faculty faculty);
        Task DeleteFaculty(string facultyId);
    }
}
