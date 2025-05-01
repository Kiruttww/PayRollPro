using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollPro
{
    public class Manager : Employee
    {
        public Manager(string name, double hourlyRate)
            : base(name, hourlyRate)
        {
            Console.WriteLine($"Manager {Name} has been hired!\n");
        }

        public Manager(int id, string name, double hourlyRate)
            : base(id, name, hourlyRate)
        {
            Console.WriteLine($"Manager {Name} has been hired!\n");
        }
        public override double CalculatePay()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}. \n");
            double total = CalculatePay();
            Console.WriteLine($"Role: Manager, Total Weekly Pay: ${total}.\n");
        }
    }
}
