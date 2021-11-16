using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class Gender
    {
        [Key]
        public int GenderID { get; set; }

        public string GenderName { get; set; }      



    }
}
