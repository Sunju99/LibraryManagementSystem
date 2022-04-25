using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface IBookStatus
    {
        Task<IEnumerable<BookStatus>> GetBookStatus();
        Task<BookStatus> GetBookStatus(int bookStatusId);
        Task AddBookStatus(BookStatus bookStatus);
        Task<BookStatus> UpdateBookStatus(BookStatus bookStatus);
        Task DeleteBookStatus(int bookStatusId);
    }
}
