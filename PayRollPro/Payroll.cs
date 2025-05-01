using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollPro
{
    public class Payroll
    {
        private List<Employee> employees;

        public Payroll()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public double CalculateTotalPayroll()
        {
            double total = 0;
            foreach (var employee in employees)
            {
                total += employee.CalculatePay();
            }
            return total;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public string GetPayrollDetails()
        {
            string details = "";
            foreach (var employee in employees)
            {
                details += $"{employee.Name}: ${employee.CalculatePay()}\n";
            }
            return details;
        }

        public Employee GetEmployee(string name)
        {
            Employee emp = employees.Find(x => x.Name == name);
            return emp;
        }
    }
}
