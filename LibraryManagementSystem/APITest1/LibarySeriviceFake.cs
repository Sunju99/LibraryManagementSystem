using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APITest1
{
   public class LibarySeriviceFake 
    {
        private readonly List<EBook> _eBooks;
        public LibarySeriviceFake()
        {
            _eBooks = new List<EBook>()
            {
                new EBook(){EBookId=1,EBookName="EBook1",ISBN="AFE12",Author="Roy",Description="Good",Publisher="Mohan"},
                new EBook(){EBookId=2,EBookName="EBook2",ISBN="AFE32",Author="joy",Description="Good",Publisher="Mohan"},
                new EBook(){EBookId=3,EBookName="EBook3",ISBN="AFE13",Author="Ray",Description="Good",Publisher="Mohan"},
                new EBook(){EBookId=4,EBookName="EBook4",ISBN="AFE15",Author="Sunju",Description="Good",Publisher="Mohan"}

            };
        }
        public EBook AddEbook(EBook eBook)
        {
            _eBooks.Add(eBook);
            return (eBook);
        }

        public void DeleteEbookAsync(int eBookId)
        {
            EBook eBook = _eBooks.Find(a => a.EBookId == eBookId);
            _eBooks.Remove(eBook);
        }

        public EBook GetEbook(int eBookId)
        {
            return _eBooks.Find(a => a.EBookId == eBookId);
        }

        public IEnumerable<EBook> GetEbookAsync()
        {
            return _eBooks;
        }

       
    }
}
