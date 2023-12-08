using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.WithoutAbstraction
{
    public abstract class EmployeeBuilder2
    {
        protected Employee2 employee2 = new();
        protected abstract void SetFullName (string fullName);
        protected abstract string SetAddress(string address);
        protected abstract string SetEmailAddress (string email);
        public Employee2 BuildEmployeeBuilder2()
        {
            return employee2;
        }
    }
}
