using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface IStudent
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudent(int studentId);
        Task AddStudent(Student student);
        Task<Student> UpdateStudent(Student student);
        Task DeleteStudent(int studentId);
    }
}
