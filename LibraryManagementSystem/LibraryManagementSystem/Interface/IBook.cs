using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface IBook
    {
        Task<IEnumerable<Book>> GetBookAsync();
        Task<Book> GetBook(int bookid);
        Task AddBook(Book book);
        Task<Book> UpdateBookAsync(Book book);
        Task DeleteBookAsync(int bookId);
    }
}
