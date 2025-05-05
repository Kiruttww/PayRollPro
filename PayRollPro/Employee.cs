using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollPro
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeId;
        public double HourlyRate { get; set; }
        public double HoursWorked { get; private set; }
        public double Tips { get; private set; }

        public string Role { get; set; }

        public Employee(string name, double hourlyRate, string role)
        {
            Name = name;
            HourlyRate = hourlyRate;
            Role = role;
            HoursWorked = 0;
            Tips = 0;
        }

        public Employee(int id, string name, double hourlyRate, string role)
        {
            Name = name;
            EmployeeId = id;
            HourlyRate = hourlyRate;
            Role = role;
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

        public double CalculatePay()
        {
            return HourlyRate * HoursWorked + Tips;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}, Tips: {Tips:C}");
            double total = CalculatePay();
            Console.WriteLine($"Role: {Role}, Total Weekly Pay: ${total}.\n");
        }
    }
}
