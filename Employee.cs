using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    class Employee
    {
        // Fields
        private string _name;   // The employee's name
        private double _idNumber;  // ID Number
        private string _department; // The name of the department which the employee works
        private string _position; // The employee's job title

        // Constructor
        public Employee(string name, double idNumber, string department, string position)
        {
            _name = name;
            _idNumber = idNumber;
            _department = "";
            _position = "";
        }
        public Employee()
        {
            _name = "";
            _idNumber = 0;
            _department = "";
            _position = "";
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // ID Number propety
        public double IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }
        }

        // Department property
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        // Position property
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }


    }
}
