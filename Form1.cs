using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Class
{
    public partial class Form1 : Form
    {
        List<Employee> employeeList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }
        
        // The GetEmployeeInfo1 method accepts a Employee object
        // as an arguement for the first employee.
         
        private void GetEmployeeInfo1(Employee info)
        {
            info.Name = "Susan Meyers";
            info.IdNumber = 47899;
            info.Department = "Accounting";
            info.Position = "Vice President";
            
        }

        // The GetEmployeeInfo2 method accepts a Employee object
        // as an arguement for the second employee.

        private void GetEmployeeInfo2(Employee info)
        {
            info.Name = "Mark Jones";
            info.IdNumber = 39119;
            info.Department = "IT";
            info.Position = "Programmer";
        }

        // The GetEmployeeInfo3 method accepts a Employee object
        // as an arguement for the third employee.

        private void GetEmployeeInfo3(Employee info)
        {
            info.Name = "Joy Rogers";
            info.IdNumber = 81774;
            info.Department = "Manufacturing";
            info.Position = "Engineer";
        }

        private void buttonShowEmployees_Click(object sender, EventArgs e)
        {
            // Create an Employee object for first employee
            Employee employee1 = new Employee();

            // Create an Employee object for second employee
            Employee employee2 = new Employee();

            // Create an Employee object for third employee
            Employee employee3 = new Employee();

            // Get the employee info
            GetEmployeeInfo1(employee1);
            GetEmployeeInfo2(employee2);
            GetEmployeeInfo3(employee3);

            // Add the employee objects to a list
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);

            // Display the employees in a list
            employeeListBox.Items.Add("Name: " + employee1.Name + "  " + "ID Number: " + employee1.IdNumber + "     " + "Deparment: " + employee1.Department + "      " + "Position: " + employee1.Position);
            employeeListBox.Items.Add("Name: " + employee2.Name + "     " + "ID Number: " + employee2.IdNumber + "      " + "Deparment: " + employee2.Department + "                      " + "Position: " + employee2.Position);
            employeeListBox.Items.Add("Name: " + employee3.Name + "     " + "ID Number: " + employee3.IdNumber + "      " + "Deparment: " + employee3.Department + "    " + "Position: " + employee3.Position);

        }

        private void employeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }


    }
}
