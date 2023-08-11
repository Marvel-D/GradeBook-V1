// See https://aka.ms/new-console-template for more information

//* using namespaces to get access to collections and types
using System;
using System.Collections.Generic;

namespace GradeBook
// the namespace ensures security for the code and classes written in it incase a similar named class is defined into the global namespace
{
    class Program
    {
        //* method named Main
        static void Main(string[] args)
        //* c# is a strongly typed language
        //* the parameters in a method consist of a type(e.g: string[]) and a name(e.g: args)
        {
            // initialize an array
            double[] numbersInArray = new double[3] { 12.2, 10.2, 12.7 };
            // * or  double[] numbers = new[] { 12.4, 10.23, 11.7 };

            // initialize a list
            List<double> numbersInList = new List<double>() { 12.4, 10.2, };

            // declare variables with a type (e.g double, var, etc) and a name (e.g x)
            // examples of explicit type with doubles, float, int, etc

            //* use 'new' keyword to instantiate an object
            var book = new Book("MTH 101 GradeBook");

            // Console.WriteLine("enter grade");
            // string? userInput;

            // userInput = Console.ReadLine();
            // while (userInput != "q")
            // {
            //     Console.WriteLine("Enter a grade");
            //     book.AddGrade(Convert.ToDouble(userInput));
            //     Console.WriteLine("enter another grade or enter q to compute grades ");
            //     userInput = Console.ReadLine();
            // }

            //* or

            while (true)
            {
                Console.WriteLine("Enter a grade or enter 'q' to compute grades ");
                var userInput = Console.ReadLine();
                if (userInput == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(userInput ?? "");
                    book.AddGrade(grade);
                } //* catch errors individually based on what you can handle
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                } //* final code block that runs regardless of the error status of the previous syntax
                finally
                {
                    Console.WriteLine("**");
                }
            }
            var stats = book.GetStatistics();

            Console.WriteLine($"The book name is {book.Name}");
            Console.WriteLine($"The lowest grade in MTH 101 is {Math.Round(stats.Low)}");
            Console.WriteLine($"The highest grade in MTH 101 is {stats.High, 1}"); // precision returns value to 1 DP
            Console.WriteLine($"The average grade in MTH 101 is {stats.average:N2}"); // returns result to string in 2 decimal place
        }
    }
}

// use '--' to distinguish between application parameters and dotnet parameters
