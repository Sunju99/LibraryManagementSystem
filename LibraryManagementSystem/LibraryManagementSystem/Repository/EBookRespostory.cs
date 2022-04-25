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
    public class EBookRespostory : IEBook
    {
        private readonly LibraryDBContext _libraryDBContext;

        public EBookRespostory(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public async Task AddEbook(EBook eBook)
        {
            await _libraryDBContext.EBooks.AddAsync(eBook);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteEbookAsync(int eBookId)
        {
            EBook eBook = new EBook()
            {
                EBookId = eBookId
            };
            _libraryDBContext.EBooks.Remove(eBook);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task<EBook> GetEbook(int eBookId)
        {
            return await _libraryDBContext.EBooks.FindAsync(eBookId);
        }

        public async Task<IEnumerable<EBook>> GetEbookAsync()
        {
            return await _libraryDBContext.EBooks.ToListAsync();
        }

        public async Task<EBook> UpdateEbookAsync(EBook eBook)
        {
            _libraryDBContext.EBooks.Update(eBook);
            await _libraryDBContext.SaveChangesAsync();
            return eBook;
        }
    }
}
