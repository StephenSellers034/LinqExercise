﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            
                Console.WriteLine(numbers.Sum());

            //TODO: Print the Average of numbers

            Console.WriteLine(numbers.Average());
            Console.WriteLine();
            //TODO: Order numbers in ascending order and print to the console

            var ascendingOrder = numbers.OrderBy(x => x);
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console

            var descendingOrder = numbers.OrderByDescending(x => x);
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();   

            //TODO: Print to the console only the numbers greater than 6

            var greaterThenSix = numbers.Where(x => x > 6);
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            foreach(int item in numbers.Take(4))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            numbers.SetValue(29, 4);
            foreach(var item in descendingOrder)
            {
                Console.WriteLine(item);
            }
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var sortByCOrS = employees.Where(x => x.FirstName.StartsWith("c") ||  x.FirstName.StartsWith("s"));
            foreach(var item in sortByCOrS)
            {
                Console.WriteLine(item.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var plus26 = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
            foreach(var item in plus26)
            {
                Console.WriteLine($"Age is : {item.Age}, FullName is : {item.FullName}");
            }

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var sumYears = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine($"{sumYears.Sum(x => x.YearsOfExperience)}");
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var averageYears = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine($"{averageYears.Average(x => x.YearsOfExperience)}");
            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("Little", "Man", 29, 5)).ToList();
            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }
           

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
