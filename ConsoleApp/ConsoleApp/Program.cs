using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            Console.Write("Enter Your Age: ");

            string Name = Console.ReadLine();
            byte Age = Convert.ToByte(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
