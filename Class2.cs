using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuctions
{
    //public class Car
    //{

    //        public string model;
    //        public string color;
    //        public string make;

    //        public Car()
    //        {
    //            Console.WriteLine("constructor of parent object ");
    //        }

    //        public void canrun()
    //        {
    //            Console.WriteLine("parent class car");
    //        }


    //}
    //    public class double_cabin : Car 
    //    {
    //    public double_cabin(string model,string color ,string make)
    //        {
    //            this.model = model;
    //            this.color=color;
    //            this.make = make;
    //            Console.WriteLine($"the propeties of child class are: {model} {color} and {make}");
    //        }
    //    public void varient()
    //    {
    //        Console.WriteLine("Rocco 2022");
    //    }

    //    }

    public class A
    { 
    public void method1()
        {
            Console.WriteLine("parent class");
        }
    }


    public class B:A
    {
        public void method2()
        {
            Console.WriteLine("child 1 class");
        }
    }

    public class C : B
    { 
    public void method3()
        {
            Console.WriteLine("child 2 class");
        }
    }


}
