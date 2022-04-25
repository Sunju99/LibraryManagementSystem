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
    public class StudentRepostory : IStudent
    {
        private readonly LibraryDBContext _libraryDBContext;

        public StudentRepostory(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public async Task AddStudent(Student student)
        {
            await _libraryDBContext.Students.AddAsync(student);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteStudent(int studentId)
        {
            Student student = new Student()
            {
                StudentId = studentId
            };
            _libraryDBContext.Students.Remove(student);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task<Student> GetStudent(int studentId)
        {
            return await _libraryDBContext.Students.FindAsync(studentId);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _libraryDBContext.Students.ToListAsync();
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            _libraryDBContext.Students.Update(student);
            await _libraryDBContext.SaveChangesAsync();
            return student;
        }
    }
}
