using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.WithAbstraction
{
    public class EmployeeBuilder
    {
        private Employee employee = new();
        public EmployeeBuilder SetFullName (string fullName)
        {
            string[] array = fullName.Split(new[] {' ','-',',','.'});
            employee.FirstName = array[0];
            employee.LastName = array[1];
            return this;
        }
        public EmployeeBuilder SetEmailAddress (string email)
        {
            employee.EmailAddress = email;
            return this;
        }
        public EmployeeBuilder SetAddress (string address)
        {
            employee.Address = address;
            return this;
        }
        public Employee BuildEmployeeBuilder()
        {
            return employee;
        }
    }
}