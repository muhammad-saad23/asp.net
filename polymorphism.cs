using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuctions
{
    class method_overloading
    { 
    public void addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void addition(float a,int b)
        {
            Console.WriteLine(a + b);
        }
        //public void addition(int a, decimal b, string c)
        //{
        //    Console.WriteLine(a + b + c);
        //}

    }


    internal class polymorphism
    {
        static void main(string[] args)
        {
            method_overloading add=new method_overloading();    
            add.addition(1,2);
            add.addition(2.10f,3);
            //add.addition(5, 1.5m,"number");
        }
    }
}
