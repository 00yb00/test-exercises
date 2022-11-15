using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_exercises
{
    internal class exercises_7
    {
        public void Run()
        {
        //parmeter and variable
        MyInterface m1 =new Myobject();
        }

    }
    //build interface
    interface MyInterface
    {
        void PrintSomthing(string str);
        double PriceAfterMammm(double price);
       
    }
    //implement the interface
    class Myobject : MyInterface
    {
        public double PriceAfterMammm(double price)
        {
           return price * 1.17;
        }

        public void PrintSomthing(string str)
        {
            Console.WriteLine("hi from: "+str);
        }
    }
}
