using System;
using CourseEmployee.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace CourseEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter number of employees:  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valuePerhours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valuePerhours, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerhours));
                }
            }
                Console.WriteLine();
                Console.WriteLine("Payments: ");

                foreach( Employee emp in list)
                {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            
        }
    }
}
