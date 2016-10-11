using System;
using System.Collections.Generic;

namespace Mocking
{
    public class Employee
    {
        public int Id { get; internal set; }
        public MailBox MailBox { get; internal set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Wage { get; set; }

        internal double CalculateWeeklySalary(int hours, double wage)
        {
            return hours * wage;
        }
        internal double CalculateWeeklySalary(int hours, double wage, User user)
        {
            if (user.Rights.Equals(Right.Full))
            {
                return (hours * wage);
            }
            else
            {
                throw new Exception("You do not have access to that feature.");
            }
        }

        internal double CalculateAverageWeeklySalary(List<double> weeklySalary)
        {
            double total = 0;
            foreach (double salary in weeklySalary)
            {
                total = total + salary;
            }
            return total / weeklySalary.Count;
        }
        internal double CalculateAverageWeeklySalary(List<double> weeklySalary, User user)
        {
            if ((user.Rights).Equals(Right.Full))
            {
                double total = 0;
                foreach (double salary in weeklySalary)
                {
                    total = total + salary;
                }
                return total / weeklySalary.Count;
            }
            else
            {
                throw new Exception("You don't have access to that feature.");
            }
        }
    }
}