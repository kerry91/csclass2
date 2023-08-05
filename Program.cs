// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using com.hr;

Manager m = new Manager { Firstname = "Terry", Lastname = "Munks", Salary = 30000, Filename = 
"Employees.csv"};
foreach(Employee emp in m.Employees)
{
    Console.WriteLine(emp.Firstname);
}

List<Car> cars = new List<Car>();
for (int i = 0; i < 32; i++)
{
    cars.Add(new Car { Assigned = false, ID = i });
}

int idx = new Random().Next(cars.Count);
m.CompanyCar = cars[idx];
cars[idx].Assigned=true;
Console.WriteLine(m);