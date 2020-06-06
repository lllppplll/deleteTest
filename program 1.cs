using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            MyFunction(name);
            
            Console.ReadLine();
        }
    static void MyFunction(string a)
    { 
            Console.WriteLine("hello " + a);
        }
}
}
