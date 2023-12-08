using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.WithoutAbstraction
{
    public interface IEmployeeBuilder2
    {
        Employee2 BuildEmployeeBuilder2();
        void SetFullname(string fullName);
        string SetAddress(string address);
        string SetEmailAddress(string emailAddress);
    }
}
