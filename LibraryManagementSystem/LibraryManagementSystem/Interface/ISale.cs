using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface ISale
    {
        Task<IEnumerable<Sale>> GetSales();
        Task<Sale> Getsale(int saleId);
        Task Addsale(Sale sale);
        Task<Sale> UpdateSale(Sale sale);
        Task DeleteSale(int saleId);
    }
}
