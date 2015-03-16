using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Enter a number....");
            number = int.Parse(Console.ReadLine());

            while(number<50)
            {
                Console.WriteLine(number);
                number++;
            }

            Console.ReadLine();
        }
    }
}