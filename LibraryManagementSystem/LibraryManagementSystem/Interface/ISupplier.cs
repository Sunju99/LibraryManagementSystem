using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    public interface ISupplier
    {
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<Supplier> GetSupplier(int supplierId);
        Task AddSupplier(Supplier supplier);
        Task<Supplier> UpdateSupplierDetail(Supplier supplier);
        Task DeleteSupplier(int supplierId);
    }
}
