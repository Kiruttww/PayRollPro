using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollPro
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeId;
        public double HourlyRate { get; set; }
        public double HoursWorked { get; private set; }
        public double Tips { get; private set; }

        public Employee(string name, double hourlyRate)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = 0;
            Tips = 0;
        }

        public Employee(int id, string name, double hourlyRate)
        {
            Name = name;
            EmployeeId = id;
            HourlyRate = hourlyRate;
            HoursWorked = 0;
            Tips = 0;
        }

        public void RecordHours(double hours)
        {
            HoursWorked += hours;

            Console.WriteLine($"{Name} has recorded {hours} hours this week.\n");
        }

        // Method to record tips received
        public void RecordTips(double tips)
        {
            Tips += tips;
        }

        public abstract double CalculatePay();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}, Tips: {Tips:C}");
        }
    }
}
