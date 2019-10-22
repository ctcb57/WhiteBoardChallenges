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
            //int[] A = { 4, 5, 7, 8, 4, 6 };
            //int n = 7;
            //string test = "foo $ foo $ foo $";
            ////int [] result = box.ReturnNoDuplicates(A);
            //int result = box.SumEvenNumbers(A);
            //string result2 = box.RemoveSecondThird(test);
            int[] arr = { 4, 5, 6, 7, -2, -3, 0, 0 };
            box.plusMinus(arr);

            Console.ReadLine();
        }
    }
}
