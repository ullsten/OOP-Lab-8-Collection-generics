//using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Lab_8___Collection_generics
{

    internal class ListClass
    {
        Employee Emp1 = new Employee() { EmpID = 30, Position = "Boss", Name = "Oskar", Gender = "Male", Age = 40, Salary = 68000 };
        Employee Emp2 = new Employee() { EmpID = 31, Position = "Seller", Name = "Knaus", Gender = "Male", Age = 32, Salary = 28000 };
        Employee Emp3 = new Employee() { EmpID = 32, Position = "Seller", Name = "Fiona", Gender = "Female", Age = 25, Salary = 29000 };
        Employee Emp4 = new Employee() { EmpID = 33, Position = "Warehouse", Name = "Lizen", Gender = "Female", Age = 27, Salary = 27500 };
        Employee Emp5 = new Employee() { EmpID = 34, Position = "Sell manager", Name = "Bjorn", Gender = "Male", Age = 52, Salary = 48000 };
        List<Employee> empList = new List<Employee>();

        public void ListProgram()
        {
            Console.Clear();
            empList.Add(Emp1);
            empList.Add(Emp2);
            empList.Add(Emp3);
            empList.Add(Emp4);
            empList.Add(Emp5);
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("DotNet LC ListPart");
            Console.ResetColor();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Check if employee #2 is at work.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("------------------------------------------");
            Thread.Sleep(400);
            if (empList.Contains(Emp2))
            {
                Console.WriteLine("Employee " + Emp2.Name + " with ID: " + Emp3.EmpID + " is at work!");
            }
            else
            {
                Console.WriteLine("Employee " + Emp2.Name + " is at home!");
            }
            
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Checking for first male employees");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------");

            Console.WriteLine(empList.Find(e => e.Gender == "Male"));                   //Find first "Male" in this case

            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("There may be more male employees as well. ");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------");
            Thread.Sleep(300);
            List<Employee> MaleEmployees = empList.FindAll(employee => employee.Gender == "Male");              //Find all male employee
            foreach (var gender in MaleEmployees)
            {
                Console.WriteLine(gender);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("And there are female employees as well");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------");
            List<Employee> FemaleEmployees = empList.FindAll(employee => employee.Gender == "Female"); //Find all female employee
            foreach (var gender in FemaleEmployees)
            {
                Console.WriteLine(gender);
            }   
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("||Any key to see menu||");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
            Program.ShowMenu();
        }
    }
}
