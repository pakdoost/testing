using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class Designation
    {
        [Key]
        public int DesignationID { get; set; }

        public string DesignationName { get; set; }     

    }
}
