using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_8___Collection_generics
//Oskar Ullsten 820304
//SUT 22-24
{
    internal class Program
    {


        static void Main(string[] args)
        {
            ShowMenu();
        }

        public static void ShowMenu()
        {
            ListClass listClass = new ListClass();
            StackClass stackClass = new StackClass();

            int userInput;
            do
            {
                Console.WriteLine("Welcome to Dot.Net LC");
                Console.WriteLine("");
                Console.WriteLine("||StackPart|#1||");
                Console.WriteLine("||ListPart |#2||");
                Console.WriteLine("||ExitPart |#3||");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("What part of DotNet do you want to see?");
                Console.WriteLine("---------------------------------------");
                Console.ResetColor();
                Int32.TryParse(Console.ReadLine(), out userInput);
                Console.Clear();
            } while (userInput < 1 || userInput > 3);

            switch (userInput)
            {
                case 1:
                    stackClass.StackProgram();
                    break;
                case 2:
                    listClass.ListProgram();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("You are fired! But you get a heart anyway!");
                    HeartPattern();
                    Environment.Exit(0);
                    break;
                    //default:
                    //    Console.WriteLine("Invalid chooice.");
                    //    break;
            }
        }
        public static void HeartPattern()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            // size of Heart
            int a, b, size = 10;

            /* FOR THE APEX OF HEART */
            for (a = size / 2; a <= size; a = a + 2)
            {

                // FOR SPACE BEFORE PEAK-1 : PART 1
                for (b = 1; b < size - a; b = b + 2)
                    Console.Write(" ");

                // FOR PRINTING PEAK-1 : PART 2
                for (b = 1; b <= a; b++)
                    Console.Write("A");

                // FOR SPACE B/W PEAK-1 AND PEAK-2 : PART 3
                for (b = 1; b <= size - a; b++)
                    Console.Write(" ");

                // FOR PRINTING PEAK-2 : PART 4
                for (b = 1; b <= a - 0; b++)
                    Console.Write("A");

                Console.WriteLine();
            }

            /*FOR THE BASE OF HEART ie. THE INVERTED TRIANGLE */
            for (a = size; a >= 0; a--)
            {

                // FOR SPACE BEFORE THE INVERTED TRIANGLE : PART 5
                for (b = a; b < size; b++)
                    Console.Write(" ");

                // FOR PRINTING THE BASE OF TRIANGLE : PART 6
                for (b = 1; b <= ((a * 2) - 1); b++)
                    Console.Write("B");

                Console.WriteLine("");

            }
            Console.ResetColor();
        }

    }

}
