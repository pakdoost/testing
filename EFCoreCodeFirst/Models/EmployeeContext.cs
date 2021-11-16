using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class EmployeeContext :  DbContext    
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options) 
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Designation> Designations { get; set; }

        public DbSet<Group> Groups { get; set; }


    }
}
