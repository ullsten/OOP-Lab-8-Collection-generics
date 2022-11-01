using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_8___Collection_generics
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }

        private string PrintEmployee()
        {
            return "Employee ID: " + EmpID + " Name: " + Name + " Age: " + Age;
        }
        public override string ToString()
        {
            return string.Format("|Name: {0} | ID: {1} | Position: {2} | Gender: {3} | Age: {4} | Salary: {5}$ |",
                this.Name,
                this.EmpID,
                this.Position,
                this.Gender,
                this.Age,
                this.Salary);
        }
    }
}