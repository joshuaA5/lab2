﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using Lab2.entities;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Relative path to employees.txt file
            string path = "employees.txt";

            // Get lines/rows in file as string array
            string[] lines = File.ReadAllLines(path);

            // Create list that holds any type of Employee
            List<Employee> employees = new List<Employee>();

            // Loop through each line/row
            foreach (string line in lines)
            {
                // Extract each part/cell from line/row
                string[] parts = line.Split(':');

                // First part is ID
                string id = parts[0];

                // Second part is name
                string name = parts[1];

                // TODO: Get remaining employee info from parts

                string address = parts[2];
                string phone = parts[3];
                string sin = parts[4];
                string birthdate = parts[5];
                string department = parts[6];

                // Get first digit of ID
                string firstDigit;

                firstDigit = id.Substring(0, 1);

                /*if (firstDigit == "0" || firstDigit == "1" || firstDigit == "2" || firstDigit == "3" || firstDigit == "4")
                {
                }*/

                // Convert first digit from string to int.
                int firstDigitNum = int.Parse(firstDigit);

                // Test what range first digit falls into
                if (firstDigitNum >= 0 && firstDigitNum <= 4)
                {
                    // Salaried
                    double salary = double.Parse(parts[7]);

                    // Create instance of Salaried
                    Salaried salaried;

                    salaried = new Salaried(id, name, salary, address, phone, sin);

                    // Add to employees
                    employees.Add(salaried);
                }
                else if (firstDigitNum >= 5 && firstDigitNum <= 7)
                {
                    // Waged
                    double rate = double.Parse(parts[7]);
                    double hours = double.Parse(parts[8]);

                    // TODO: Create Waged instance and add it to employee list.
                    Waged waged = new Waged(id, name, rate, hours, address, phone, sin);
                    employees.Add(waged);
                }
                else if (firstDigitNum >= 8 && firstDigitNum <= 9)
                {
                    // Part time
                    double rate = double.Parse(parts[7]);
                    double hours = double.Parse(parts[8]);

                    // Create PartTime instance and add it to employee list.
                    PartTime partTime = new PartTime(id, name, rate, hours, address, phone, sin);
                    employees.Add(partTime);
                }


            }

            /**
            * TODO:
            *  - Determine lowest paid salaried employee.
            *  - Determine percentage of employees that are salaried, waged, and part-time.
            */

            double averageWeeklyPay = CalcAverageWeeklyPay(employees);

            Console.WriteLine(string.Format("Average weekly pay: {0:C2}", averageWeeklyPay));

            Employee highestPaidWagedEmployee = FindHighestPaid(employees);

            double highestWagedPay = highestPaidWagedEmployee.Pay;

            Console.WriteLine("Highest waged pay: " + highestWagedPay.ToString("C2"));
            Console.WriteLine("Highest waged employee: " + highestPaidWagedEmployee.Name);
        }

        private static double CalcAverageWeeklyPay(List<Employee> employees)
        {
            double weeklyPaySum = 0;

            // It's okay to use loop through employees multiple times.
            foreach (Employee employee in employees)
            {
                if (employee is PartTime partTime)
                {
                    //PartTime partTime= (PartTime)employee;
                    double pay = partTime.Pay;
                    weeklyPaySum += pay;
                }
                else if (employee is Waged waged)
                {
                    double pay = waged.Pay;

                    weeklyPaySum += pay;
                }
                else if (employee is Salaried salaried)
                {
                    double pay = salaried.Pay;

                    weeklyPaySum += pay;
                }
            }

            double averageWeeklyPay = weeklyPaySum / employees.Count;

            return averageWeeklyPay;
        }

        private static Waged FindHighestPaid(List<Employee> employees)
        {
            double highestWagedPay = 0;
            Waged highestWagedEmployee = null;

            foreach (Employee employee in employees)
            {
                if (employee is Waged waged)
                {
                    double pay = waged.Pay;

                    if (pay > highestWagedPay)
                    {
                        highestWagedPay = pay;
                        highestWagedEmployee = waged;
                    }
                }
            }

            return highestWagedEmployee;
        }

        private static Salaried FindLowestPaid(List<Employee> employees)
        {
            // Rename to lowestSalariedPay
            // Change to highest possible value
            double lowestSalariedPay = double.MaxValue;
            // Change type to Salaried
            // Rename to lowestSalariedEmployee
            Salaried lowestsalariedEmployee = null;

            foreach (Employee employee in employees)
            {
                // Check if employee is Salaried
                if (employee is Salaried salaried)
                {
                    double pay = salaried.Pay;

                    // Reverse to check if pay is less than lowestSalariedPay
                    if (pay < lowestSalariedPay)
                    {
                        lowestSalariedPay = pay;
                        lowestsalariedEmployee = salaried;
                    }
                }
            }

            return lowestsalariedEmployee;
        }
    }
}
