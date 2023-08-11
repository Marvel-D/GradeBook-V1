// using System.Collections.Generic;

namespace GradeBook
{
    // a class can be said to consist of two things, the state(or data) and the behavior acting on the state
    public class Book
    {
        //* defining a constructor method
        //* if an access modifier is not specified for a class, it will be specified as internal (can only be used in same project) automatically
        public Book(string name)
        {
            grades = new List<double>();
            // implicit variable 'this'
            this.name = name;
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        /*
        *AddGrade is declared twice but does not throw any error. This is because the C# method overloading feature which take advantage of the
        *fact that th C# complier looks at not just the method name but the method signature (which consists of method name and parameter types and num. of parameters) as well
        ! note: the return type does not count
        */
        public void AddGrade(double grade)
        {
            //* 'if' conditional can be used as a branching statement
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                // throw an exception to customize erroneous user inputs and prevent crashing
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics
            {
                average = 0.0,
                High = double.MinValue,
                Low = double.MaxValue
            };

            foreach (double grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                // if (number < lowGrade)
                // {
                //     lowGrade = number;
                // }
                //? or
                result.Low = Math.Min(grade, result.Low);
                result.average += grade;
            }

            result.average /= grades.Count;

            return result;
        }

        // 'do while' loop runs a block of code at least once before checking the condition unlike 'while' loop
        // break out of a conditional statement with the 'break' statement
        // skip a specified conditional instance and continue the loop statement with the 'continue' statement

        //* field
        private List<double> grades;

        //* a pro
        public string Name
        {
            get { return name; }
        }

        private string name;

        //*
    }
}
