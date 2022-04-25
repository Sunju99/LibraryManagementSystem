using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface IEBook
    {
        Task<IEnumerable<EBook>> GetEbookAsync();
        Task<EBook> GetEbook(int eBookId);
        Task AddEbook(EBook eBook);
        Task<EBook> UpdateEbookAsync(EBook eBook);
        Task DeleteEbookAsync(int eBookId);
    }
}
