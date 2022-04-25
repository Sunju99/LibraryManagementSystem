using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Faculty
    {
        [Key]
        public string FacultyId { get; set; }

        public string FacultyName { get; set; }

        public string FacultyEmail { get; set; }
        [MaxLength(50)]
 
        public string FacultyPhone { get; set; }

        public string FacultyAddress { get; set; }

        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }

        public int DesignationId { get; set; }
    }
}
