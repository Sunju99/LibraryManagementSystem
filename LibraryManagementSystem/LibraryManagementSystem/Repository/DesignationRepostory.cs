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
    public class DesignationRepostory : IDesignation
    {
        private readonly LibraryDBContext _libraryDBContext;

        public DesignationRepostory(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public async Task AddDesignation(Designation designation)
        {
            await _libraryDBContext.Designations.AddAsync(designation);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteDesignation(int designationId)
        {
            Designation designation = new Designation()
            {
                DesignationId = designationId
            };
            _libraryDBContext.Designations.Remove(designation);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task<Designation> GetDesignation(int designationId)
        {
            return await _libraryDBContext.Designations.FindAsync(designationId);
        }

        public async Task<IEnumerable<Designation>> GetDesignations()
        {
            return await _libraryDBContext.Designations.ToListAsync();
        }

        public async Task<Designation> UpdateDesignation(Designation designation)
        {
            _libraryDBContext.Designations.Update(designation);
            await _libraryDBContext.SaveChangesAsync();
            return designation;
        }
    }
}
