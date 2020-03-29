using Employee_Repository.Models;
using Employee_Repository.Repository.Contract.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_Repository.Repository.Contract
{
    public class EmployeeRepository : Repository<Employee>, IRepository<Employee>
    {
        public EmployeeRepository(EmpContext context) : base(context)
        {

        }
    }
}