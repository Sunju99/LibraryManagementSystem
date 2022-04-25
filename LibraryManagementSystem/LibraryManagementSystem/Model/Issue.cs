using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Issue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IssueId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public int StudentId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int BookId { get; set; }

        public string Message { get; set; }
    }
}
