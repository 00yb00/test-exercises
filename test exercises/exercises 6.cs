using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_exercises
{        
    internal class exercises_6
    {
    
    }
    //abstract class
    abstract class MyPerson
    {
        public string name { get; set; }
        public int age { get; set; }
        public string id { get; set; }
        //abstract function

        //print all the details int specific person
        public abstract void Print();
    }
}
