using System;

namespace Mocking
{
    public class User
    {
        public int NumMessagesCreated { get; internal set; }
        public string Password { get; internal set; }
        public object Rights { get; internal set; }
        public string UserName { get; internal set; }

        internal string ViewAllEmployees()
        {
            return "Here is the list";
        }

        internal void EditEmployeeName(Employee employee, string newName)
        {
            if (Rights.Equals(Right.Full))
            {
                employee.Name = newName;
            }
            else
            {
                throw new Exception("You don't have access to that feature.");
            }

        }

        internal void EditEmployeeWage(Employee employee, double newWage)
        {
            if (Rights.Equals(Right.Full))
            {
                employee.Wage = newWage;
            }
            else
            {
                throw new Exception("You don't have access to that feature.");
            }
        }
    }
}