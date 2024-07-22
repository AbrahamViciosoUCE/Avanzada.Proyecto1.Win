using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Employee
{
    public class EmployeeDataProvider: IEmployeeDataProvider
    {
        NorthWindContext _northWindContext;
        public EmployeeDataProvider(NorthWindContext northWindContext) { 
            _northWindContext = northWindContext;
        }

        public IEnumerable<DataModel.Employee> GetEmployees()
        {
            return _northWindContext.Employees.ToList();
        }
    }
}
