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
    public class BookRepostory:IBook
    {
        private LibraryDBContext _context;
        public BookRepostory(LibraryDBContext context)
        {
            _context = context;
        }
        public async Task AddBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteBookAsync(int bookId)
        {
            Book bk = new Book()
            {
                BookId = bookId
            };
            _context.Books.Remove(bk);
            await _context.SaveChangesAsync();
        }
        public async Task<Book> GetBook(int bookid)
        {
            var book = await _context.Books.FindAsync(bookid);
            return book;
        }
        public async Task<IEnumerable<Book>> GetBookAsync()
        {
            var records = await _context.Books.ToListAsync();
            return records;
        }
        public async Task<Book> UpdateBookAsync(Book book)
        {
          
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }

    }
}
