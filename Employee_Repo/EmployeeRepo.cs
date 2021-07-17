using Employee_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Repo
{
    public class EmployeeRepo
    {
        private List<Employee> _listOfEmployees = new List<Employee>();
        
        public void Create(Employee employee)
        {
            _listOfEmployees.Add(employee);
        }
        public List<Employee> GetEmployees()
        {
            return _listOfEmployees;
        }
        public Employee GetEmployee(int id)
        {
            foreach (var employee in _listOfEmployees)
            {
                if (employee.ID == id)
                {
                    return employee;
                }
                
            }
            return null;
        }
    }
}
