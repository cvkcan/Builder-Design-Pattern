using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.WithAbstraction
{
    public class Employee
    {
        public Guid Id = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public override string ToString()
        {
            return $"{Id} * {FirstName} * {LastName} * {Address} * {EmailAddress}";
        }
    }
}
