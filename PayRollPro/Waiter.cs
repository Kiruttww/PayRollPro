using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollPro
{
    public class Waiter : Employee
    {
        public Waiter(string name, double hourlyRate)
            : base(name, hourlyRate)
        {
            Console.WriteLine($"Waiter {Name} has been hired!\n");
        }

        public Waiter(int id, string name, double hourlyRate)
            : base(id, name, hourlyRate)
        {
            Console.WriteLine($"Waiter {Name} has been hired!\n");
        }

        //Methods
        public override double CalculatePay()
        {
            return HourlyRate * HoursWorked + Tips;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            double total = CalculatePay();
            Console.WriteLine($"Role: Waiter, Total Weekly Pay: ${total}.\n");
        }
    }
}
