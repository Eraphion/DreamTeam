using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulTool
{
    class Program
    {
        static void Module()
        {
            Console.WriteLine("Separate module");

            Console.WriteLine("I can see Alternative branch");
            Console.WriteLine("1234567890");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("InitCommit");
            Console.WriteLine("SecondCommit");

            Console.WriteLine("Second person commit");
            for (int i = 0; i < 10; i++)
                Console.Write(i);

            Console.WriteLine("Contenu");
        }
    }
}
