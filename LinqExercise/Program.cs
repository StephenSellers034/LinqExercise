using System;
using System.Collections.Generic;
using System.Linq;
using LinqExercise;
//Static array of integers
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

/*
* 
* Complete every task using Method OR Query syntax. 
* You may find that Method syntax is easier to use since it is most like C#
* Every one of these can be completed using Linq and then printing with a foreach loop.
* Push to your github when completed!
* 
*/

//TODO: Print the Sum of numbers
Console.WriteLine("The sum of the number is: ");
Console.WriteLine(numbers.Sum());
Console.WriteLine();

            //TODO: Print the Average of numbers

Console.WriteLine("The Average is: ");
Console.WriteLine(numbers.Average());
Console.WriteLine();

//TODO: Order numbers in ascending order and print to the console

Console.WriteLine("AscendingOrder");
var ascendingOrder = numbers.OrderBy(x => x);
foreach (var item in ascendingOrder)
{
    Console.WriteLine(item);
}
Console.WriteLine();

//TODO: Order numbers in descending order and print to the console

Console.WriteLine("Descending Order:");
var descendingOrder = numbers.OrderByDescending(x => x);
foreach (var item in descendingOrder)
{
    Console.WriteLine(item);
}
Console.WriteLine();

//TODO: Print to the console only the numbers greater than 6

Console.WriteLine("Greater then six:");
var greaterThenSix = numbers.Where(x => x > 6);
foreach (int item in greaterThenSix)
{
    Console.WriteLine(item);
}
Console.WriteLine();

//TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

Console.WriteLine("Take 4");
foreach (int item in numbers.Take(4))
{
    Console.WriteLine(item);
}
Console.WriteLine();

//TODO: Change the value at index 4 to your age, then print the numbers in descending order
Console.WriteLine("My Age:");
numbers.SetValue(29, 4);
foreach (var item in descendingOrder)
{
    Console.WriteLine(item);
}
Console.WriteLine();
// List of employees ****Do not remove this****
var employees = CreateEmployees();

//TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
Console.WriteLine("First name starts with c or s: ");
var sortByCOrS = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName
.StartsWith("S"))
.OrderBy(x => x.FirstName).ToList();
foreach (var item in sortByCOrS)
{
    Console.WriteLine(item.FullName);
}
Console.WriteLine();
//TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

Console.WriteLine("Over 26:");
var plus26 = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
foreach (var item in plus26)
{
    Console.WriteLine($"Age is : {item.Age}, FullName is : {item.FullName}");
}
Console.WriteLine();

//TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

Console.WriteLine("Sum of years of experience under or equal to 10 and age over 35:");
var sumYears = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
Console.WriteLine($"{sumYears.Sum(x => x.YearsOfExperience)}");
Console.WriteLine();

//TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

Console.WriteLine("Average years of experice 10 and under age over 35:");
var averageYears = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
Console.WriteLine($"{averageYears.Average(x => x.YearsOfExperience)}");
Console.WriteLine();

//TODO: Add an employee to the end of the list without using employees.Add()

Console.WriteLine("Added employee at end of list");
employees = employees.Append(new Employee("Little", "Man", 29, 5)).ToList();
foreach (var item in employees)
{
    Console.WriteLine(item.FullName);
}


Console.ReadLine();

#region CreateEmployeesMethod
List<Employee> CreateEmployees()
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
#endregion;