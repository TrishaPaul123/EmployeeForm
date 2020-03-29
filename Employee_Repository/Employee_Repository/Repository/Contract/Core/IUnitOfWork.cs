using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Repository.Repository.Contract.Core
{
    interface IUnitOfWork
    {
        EmployeeRepository Employees { get; }
        int Complete();
    }
}
