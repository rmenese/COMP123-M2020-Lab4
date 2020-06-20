using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object of type Person
            Person rem = new Person(name:"Rem", age: 40); //fyi I just turned 40 today, smile!

            // use saysHello method with . accessor
            rem.SaysHello();

            Console.ReadLine();
        }
    }
}
