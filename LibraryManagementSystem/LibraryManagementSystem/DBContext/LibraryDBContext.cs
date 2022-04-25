using LibraryManagementSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DBContext
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {

        }
        public LibraryDBContext(DbContextOptions<LibraryDBContext> dbContextOptions)
           : base(dbContextOptions)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookStatus> BookStatuses { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<EBook> EBooks { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Issue> Issues { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
