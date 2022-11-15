using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_exercises
{
    internal class exercises_9
    {
        public void Run()
        {
        Animel a1=new CatFamily(),a2=new ReptileFamily();

        }

    }
    class Animel
    {
        public string color { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        

    }
    class CatFamily: Animel
    {
        public string name { get; set; }
        public bool HaveFur { get; set; }

    }
    class ReptileFamily : Animel
    {
        public string name { get; set; }
        public bool HaveLegs { get; set; }
        public int numbrerLegs { get; set; }
    }
}
