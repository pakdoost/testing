using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Required (ErrorMessage ="Full name is required")]
        public string Name { get; set; }

        public Gender GenderName { get; set; }

        [ForeignKey("GenderID")]
        public int GenderID { get; set; }

        public Designation Designation { get; set; }

        [ForeignKey("DesignationID")]
        public int DesignationID { get; set; }

        public int Salary { get; set; }



    }
}
