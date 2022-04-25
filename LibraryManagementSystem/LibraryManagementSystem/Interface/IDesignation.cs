using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface IDesignation
    {
        Task<IEnumerable<Designation>> GetDesignations();
        Task<Designation> GetDesignation(int designationId);
        Task AddDesignation(Designation designation);
        Task<Designation> UpdateDesignation(Designation designation);
        Task DeleteDesignation(int designationId);
    }
}
