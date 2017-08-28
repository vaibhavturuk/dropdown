using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dropdown08.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext():base("MyConnection") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<State> States { get; set; }



    }
}
