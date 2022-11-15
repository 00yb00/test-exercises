using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_exercises
{
    internal class exercises_8
    {

    }
    class Methods
    {
        //overload function
        public int SomeFunc(int num1)
        {
            return num1*10;    
        }
        public int SomeFunc(int num1, int num2)
        {
            return num1*num2;
        }
        public int SomeFunc(int num1, int num2,int num3)
        {
            return num1 + num2 * num3;
        }
    }
}
