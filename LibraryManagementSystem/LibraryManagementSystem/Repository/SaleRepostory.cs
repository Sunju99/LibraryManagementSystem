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
    public class SaleRepostory : ISale
    {
        private readonly LibraryDBContext _libraryDBContext;

        public SaleRepostory(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public async Task Addsale(Sale sale)
        {
            await _libraryDBContext.Sales.AddAsync(sale);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteSale(int saleId)
        {
            Sale sale = new Sale()
            {
               SaleId = saleId
            };
            _libraryDBContext.Sales.Remove(sale);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task<Sale> Getsale(int saleId)
        {
            return await _libraryDBContext.Sales.FindAsync(saleId);
        }

        public async Task<IEnumerable<Sale>> GetSales()
        {
            return await _libraryDBContext.Sales.ToListAsync();
        }

        public async Task<Sale> UpdateSale(Sale sale)
        {
            _libraryDBContext.Sales.Update(sale);
            await _libraryDBContext.SaveChangesAsync();
            return sale;
        }
    }
}
