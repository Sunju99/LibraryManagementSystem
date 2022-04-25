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
    public class FacultyRepostory : IFaculty
    {
        private readonly LibraryDBContext _libraryDBContext;

        public  FacultyRepostory(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public async Task AddFaculty(Faculty faculty)
        {
            await _libraryDBContext.Faculties.AddAsync(faculty);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteFaculty(string facultyId)
        {
            Faculty faculty = new Faculty()
            {
                FacultyId = facultyId
            };
            _libraryDBContext.Faculties.Remove(faculty);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task<Faculty> GetFaculty(string facultyId)
        {
            return await _libraryDBContext.Faculties.FindAsync(facultyId);
        }

        public async Task<IEnumerable<Faculty>> GetFacultys()
        {
            return await _libraryDBContext.Faculties.ToListAsync();
        }

        public async Task<Faculty> UpdateFaculty(Faculty faculty)
        {
            _libraryDBContext.Faculties.Update(faculty);
            await _libraryDBContext.SaveChangesAsync();
            return faculty;
        }
    }
}
