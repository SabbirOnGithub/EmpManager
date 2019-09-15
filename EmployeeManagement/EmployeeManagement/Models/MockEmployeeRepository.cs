using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee(){Id = 1, Name = "Sabbir1", Email = "shawon1.ict@gmail.com", Department = "Developemnt1"},
                new Employee(){Id = 2, Name = "Sabbir2", Email = "shawon2.ict@gmail.com", Department = "Developemnt2"},
                new Employee(){Id = 3, Name = "Sabbir3", Email = "shawon3.ict@gmail.com", Department = "Developemnt3"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeList;
        }
    }
}
