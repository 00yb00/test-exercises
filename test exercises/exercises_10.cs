using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_exercises
{
    internal class exercises_10
    {
     public void Run()
    {
            MyFactory myFactory = new MyFactory();
    } 
    }

    //Class Factory
    class MyFactory
    {
        public MyFurniture[] arr { get; set; }
       
        public MyFactory()
        { //the factory creat objects
            arr =new MyFurniture[100];
            arr[0]=new Closet();
            arr[0].color = "black";
            arr[0].Length = 100;
            arr[0].width = 50.5;
            (arr[0] as Closet).name = "somecloset";
            arr[1] = new Table();
            arr[2] = new Closet();
        }
       
       
    }
    class MyFurniture
    {
        public string color { get; set; }
        public double width { get; set; }
        public double Length { get; set; }

    }
    class Closet : MyFurniture
    {
        public string name { get; set; }
        public int numberDoors { get; set; }
        public int numberHandles { get; set; }

    }
    class Table : MyFurniture
    {
        public string name { get; set; }
        public bool numberlegs { get; set; }
        public Table()
        {

        }

    }
}
