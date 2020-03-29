using Employee_Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Employee_Repository
{
    public class EmpContext : DbContext
    {
        
        public EmpContext() : base("conStr") { }
        public DbSet<Employee> Employees { get; set; }
        
    }
}