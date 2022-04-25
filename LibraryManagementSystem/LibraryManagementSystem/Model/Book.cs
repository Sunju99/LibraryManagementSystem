using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
        public int Issued { get; set; }
        [ForeignKey("BookStatusId")]
        public BookStatus BookStatus { get; set; }
        public int BookStatusId { get; set; }

    }
}
