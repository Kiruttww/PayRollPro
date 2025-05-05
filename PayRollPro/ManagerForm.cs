using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayRollPro
{
    public partial class ManagerForm : Form
    {
        Payroll payroll;
        public ManagerForm()
        {
            InitializeComponent();

            List<string> roles = new List<string> { "Waiter/Waitress", "Chef", "Manager" };
            cmbRole.DataSource = roles;
            cmbNR.DataSource = new List<string>(roles);

            payroll = new Payroll();
            var records = DatabaseHelper.LoadAllEmployees();
            foreach (var (id, name, rate, role) in records)
            {
                Employee emp = null;

                emp = new Employee(id, name, rate, role);

                if (emp != null)
                {
                    payroll.AddEmployee(emp);
                    listBoxEmployees.Items.Add(emp.Name);
                }
            }
        }
        

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            Employee newEmployee = null;
            string selectedRole = cmbRole.SelectedItem?.ToString();
            string name = textBoxName.Text;
            double rate = (double)numUpDownRate.Value;


            newEmployee = new Employee(name, rate, selectedRole);
            
            DatabaseHelper.AddEmployeeToDatabase(newEmployee);
            payroll.AddEmployee(newEmployee);
            MessageBox.Show($"{selectedRole} with employee ID: {newEmployee.EmployeeId} added successfully!");

            listBoxEmployees.Items.Add(name);
            textBoxName.Text = "";
            numUpDownRate.Value = 0;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Future update, use ID using listBoxEmployees.SelectedIndex.
            //To make that happen we need error check ID when adding employees and make it go in ascending order
            //Check that they selected an employee
            if (listBoxEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Employee", "Error!");
                return;
            }

            string name = listBoxEmployees.SelectedItem.ToString();
            Employee emp = payroll.GetEmployee(name);

            if (emp != null)
            {
                MessageBox.Show($"{emp.Name}'s current pay is ${emp.CalculatePay()} and has worked {emp.HoursWorked} hours.");
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Employee", "Error!");
                return;
            }

            string name = listBoxEmployees.SelectedItem.ToString();
            var empData = DatabaseHelper.GetEmployeeByName(name);
            if (empData.HasValue)
            {
                var (id, empName, rate, role) = empData.Value;
                MessageBox.Show($"Name: {empName}\nID: {id}\nRate: ${rate:F2}\nRole: {role}", "Employee Info");
            }
            else
            {
                MessageBox.Show("Employee not found in database.", "Error");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Employee", "Error!");
                return;
            }


            txtBoxNN.Text = listBoxEmployees.SelectedItem.ToString();
            labelNewN.Visible = true;
            labelNewR.Visible = true;
            btnDone.Visible = true;
            txtBoxNN.Visible = true;
            cmbNR.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNN.Text))
            {
                MessageBox.Show("Please fill in both fields", "Error!");
                return;
            }

            string updatedName = txtBoxNN.Text;
            string updatedRole = cmbNR.SelectedItem?.ToString();


            string selectedEmployee = listBoxEmployees.SelectedItem.ToString();
            Employee emp = payroll.GetEmployee(selectedEmployee);

            if (emp != null)
            {
                // Update the employee's details
                emp.Name = updatedName;
                emp.Role = updatedRole;
                // Optionally: Update the list box item (if you want to reflect the name change)
                listBoxEmployees.Items[listBoxEmployees.SelectedIndex] = updatedName;

                // Update the database with the new information
                DatabaseHelper.UpdateEmployeeInDatabase(emp);

                MessageBox.Show("Employee information updated successfully!");
            }

            labelNewN.Visible = false;
            labelNewR.Visible = false;
            btnDone.Visible = false;
            txtBoxNN.Visible = false;
            cmbNR.Visible = false;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Employee", "Error!");
                return;
            }

            string selectedEmployee = listBoxEmployees.SelectedItem.ToString();
            Employee emp = payroll.GetEmployee(selectedEmployee);

            if (emp != null)
            {
                // Optionally: Update the list box item (if you want to reflect the name change)
                listBoxEmployees.Items.Remove(listBoxEmployees.SelectedItem);

                // Update the database with the new information
                DatabaseHelper.RemoveEmployeeFromDatabase(emp);
            }
        }
    }
}
