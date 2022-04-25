
using LibraryManagementSystem.Model;
using System;
using System.Linq;
using Xunit;

namespace APITest1
{
    public class UnitTest1
    {
        private readonly LibarySeriviceFake _libarySeriviceFake;
       
        public UnitTest1()
        {
            _libarySeriviceFake = new LibarySeriviceFake();
           
        }
        [Fact]
        public void GEtAllItems()
        {
            
            var items = _libarySeriviceFake.GetEbookAsync();
            Assert.Equal(4, items.Count);
        }
    }
}
