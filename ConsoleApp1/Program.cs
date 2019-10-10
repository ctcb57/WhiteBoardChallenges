using ConsoleApp1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandbox box = new Sandbox();
            //int []A = { 4, 5, 7, 8, 4, 6 };
            int n = 7;
            //int [] result = box.ReturnNoDuplicates(A);
            int result = box.FibonacciSequence(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
