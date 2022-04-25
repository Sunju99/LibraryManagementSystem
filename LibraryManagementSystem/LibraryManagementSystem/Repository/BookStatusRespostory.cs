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
    public class BookStatusRespostory : IBookStatus
    {
        private readonly LibraryDBContext _libraryDBContext;

        public BookStatusRespostory(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public async Task AddBookStatus(BookStatus bookStatus)
        {
            await _libraryDBContext.BookStatuses.AddAsync(bookStatus);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteBookStatus(int bookStatusId)
        {
            BookStatus bookStatus = new BookStatus()
            {
                BookStatusId = bookStatusId
            };
            _libraryDBContext.BookStatuses.Remove(bookStatus);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookStatus>> GetBookStatus()
        {
            return await _libraryDBContext.BookStatuses.ToListAsync();
        }

        public async Task<BookStatus> GetBookStatus(int bookStatusId)
        {
            return await _libraryDBContext.BookStatuses.FindAsync(bookStatusId);
        }

        public async Task<BookStatus> UpdateBookStatus(BookStatus bookStatus)
        { 

            _libraryDBContext.BookStatuses.Update(bookStatus);
            await _libraryDBContext.SaveChangesAsync();
            return bookStatus;
        }
    }
}
