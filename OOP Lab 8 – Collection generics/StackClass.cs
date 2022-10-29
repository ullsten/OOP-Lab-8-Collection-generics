using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_8___Collection_generics
{
    internal class StackClass
    {
        Employee Emp1 = new Employee() { EmpID = 30, Position = "Boss", Name = "Oskar C", Gender = "Male", Age = 40, Salary = 68000 };
        Employee Emp2 = new Employee() { EmpID = 31, Position = "Seller", Name = "Knaus J", Gender = "Male", Age = 32, Salary = 28000 };
        Employee Emp3 = new Employee() { EmpID = 32, Position = "Seller", Name = "Fiona L", Gender = "Female", Age = 25, Salary = 29000 };
        Employee Emp4 = new Employee() { EmpID = 33, Position = "Warehouse", Name = "Lizen H", Gender = "Female", Age = 27, Salary = 27500 };
        Employee Emp5 = new Employee() { EmpID = 34, Position = "Sell manager", Name = "Werner N", Gender = "Male", Age = 52, Salary = 48000 };
        Stack<Employee> EmpStack = new Stack<Employee>();

        public void StackProgram()
        {
            Console.Clear();
            PushToStack();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("DotNet LC StackPart");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var displayEmployee in EmpStack)                               //Display all items in stack.
            {
                Console.WriteLine(displayEmployee);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Items left in stack: " + EmpStack.Count);
                Console.ResetColor();
                Thread.Sleep(200);
            }
            Console.WriteLine();
            Thread.Sleep(600);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------------------------------------");  
            Console.WriteLine("Holy S**T! Boss is angry! He just dismissed(or just retrive) using Pop-Method");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();

            while (EmpStack.Count > 0)                                              //Retrive with POP method.
            {
                Console.WriteLine("{0}", EmpStack.Pop());
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Items left in stack: " + EmpStack.Count);
                Console.ResetColor();
                Thread.Sleep(200);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("Oh no! Where are my employees??");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Help the boss to get the employees back!");
            Console.WriteLine("a light touch on enter");
            Console.WriteLine();
            Console.ResetColor();
            Console.ReadKey();
            ThreadBackToWork();
            Console.WriteLine();
            PushToStack();
            Console.WriteLine("Thanks to you, all the employees are back!");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            foreach (var displayEmployee in EmpStack)                               //Displaying employees again.
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(displayEmployee);
                Console.ResetColor();
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Employees at work: " + EmpStack.Count);
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Tíme for employee interview using the peek method, who could it be?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(Employee still at work with peek method)");
            Console.ResetColor();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Interview with: ");
            Console.ResetColor(); 
            for (int i = 0; i < 2; i++)
            {
                Employee PeekEmployee = EmpStack.Peek();                            //Peek Method - return object at top of Stack without removing it.
                Console.Write(PeekEmployee);
                Console.WriteLine("Items in stack: " + EmpStack.Count);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Employee #3 is gone, looking around for her/he!");
            Console.ResetColor();
            if (EmpStack.Contains(Emp3))                                            //Check if specific employee 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Employee found: " + Emp3.Name + " with ID: " + Emp3.EmpID + " was out for a coffee. ");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine();         
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("||Any key to see menu||");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
            Program.ShowMenu();
        }
        protected void ThreadBackToWork()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GET");
            Thread.Sleep(200);
            Console.WriteLine("BACK");
            Thread.Sleep(200);
            Console.WriteLine("TO");
            Thread.Sleep(200);
            Console.WriteLine("WORK");
            Thread.Sleep(200);
            Console.WriteLine("NOW");
            Console.ResetColor();
        }
        protected void PushToStack()
        {
            EmpStack.Push(Emp1);
            EmpStack.Push(Emp2);
            EmpStack.Push(Emp3);
            EmpStack.Push(Emp4);
            EmpStack.Push(Emp5);
        }


    }
}
