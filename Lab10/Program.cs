using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab10
{
    class Program
    {
        //set a counter for the program
        static int studentCounter = 0;
        static void Main(string[] args)
        {
            //set a bool statement for my outside while loop
            bool resume = true;
            
            //instantiate
            Circle CC = new Circle();
            while (resume)
            {
                //asking user for input
                Console.Write("Enter a radius: ");
                //getting user input
                CC.Radius = Double.Parse(Console.ReadLine());
                Console.WriteLine($"The area is: {CC.CalculateArea()}");
                Console.WriteLine($"The circumference is: {CC.CalculateCircumference()}");
                Console.WriteLine($"The formatted circumference is: {CC.CalculateFormattedCircumference()}");
                Console.WriteLine($"The formatted area is: {CC.CalculateFormattedArea()}");
                studentCounter++;
                while (true)
                {
                    Console.WriteLine("(1) to quit or (2) to add another circle");
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.WriteLine($"You added {studentCounter} circles, goodbye!");
                        resume = false;
                        break;
                    }
                    else if (input == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again");
                    }
                }

                

            }
        }
    }
}
