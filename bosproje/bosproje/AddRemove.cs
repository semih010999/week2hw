using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1hw
{
    public class AddRemove
    {

        List<Employee> employees = new List<Employee>();

        public AddRemove()
        {
            employees = new List<Employee>();
        }
        public void AddEmp(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee ReadId(int idemp)
        {
            return employees[idemp];
        }

        public Employee RemoveId(int idemp)
        {
            var emp = ReadId(idemp);
            employees.RemoveAt(idemp);

            return emp;
        }

       


    }
}
