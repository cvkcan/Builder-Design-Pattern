using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.WithoutAbstraction
{
    public class SampleEmployee : IEmployeeBuilder2
    {
        protected Employee2 employee2 = new();

        public Employee2 BuildEmployeeBuilder2()
        {
            return employee2;
        }

        public string SetAddress(string address)
        {
            return employee2.Address = address;   
        }

        public string SetEmailAddress(string emailAddress)
        {
            return employee2.EmailAddress = emailAddress;   
        }

        public void SetFullname(string fullName)
        {
            string[] array = fullName.Split(new[] {',',' ','-','.'});
            employee2.FirstName  = array[0];
            employee2.LastName = array[1];
        }
    }
}
