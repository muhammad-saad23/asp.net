using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuctions
{
    internal class Employee
    {
        public int empid;
        public string empname;
        public string empemail;

        public Employee()
        {
            Console.WriteLine("first constructor");
        }

        public Employee(int empid) : this()
        {
            this.empid = empid;
            Console.WriteLine("Second constructor"+ empid);
        }
        public Employee(string empname, string empemail) : this(77)
        {
            this.empname = empname;
            this.empemail = empemail;
            Console.WriteLine($"third constructor emp id is {empid} and empname is:{empname} with email:{empemail}");

        }

    }
}
