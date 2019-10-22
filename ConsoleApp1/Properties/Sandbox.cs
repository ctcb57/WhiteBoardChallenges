using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Properties
{
    class Sandbox
    {
        public int[] A;


        //method which adds all digits in an array which have two digits whether negative or positive
        public int AddDoubleDigits(int[] A)
        {
            int result = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                if ((A[i] > 9 && A[i] < 100) || (A[i] > -100 && A[i] < -9))
                {
                    result += A[i];
                }
            }
            return result;
        }
        // Create method which removes duplicates from an array
        public int[] ReturnNoDuplicates(int[] test)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 1; j < test.Length; j++)
                {
                    if (test[i] == test[j])
                    {
                        if (result.Contains(test[i]))
                        {
                            break;
                        }
                        else
                        {
                            result.Add(test[i]);
                            break;
                        }
                    }
                }
            }
            int[] actualResult = result.ToArray();
            return actualResult;
        }

        // Create method which returns the n power of the fibonocci sequence
        public int FibonacciSequence(int n)
        {
            List<int> list = new List<int>() { 0, 1 };
            for (int i = 2; i < n + 1; i++)
            {
                int result = list[i - 2] + list[i - 1];
                list.Add(result);
            }
            return list[n];
        }

        // Create method which returns missing number from array from 1 - 100
        public int[] GenerateToOneHundred()
        {
            List<int> holder = new List<int>();
            for (int i = 1; i <= 49; i++)
            {
                holder.Add(i);
            }
            for (int j = 51; j <= 100; j++)
            {
                holder.Add(j);
            }
            int[] result = holder.ToArray();
            return result;
        }

        public int FindMissingNumber()
        {
            int missingNumber = 0;
            int[] array = GenerateToOneHundred();
            for (int i = 1; i < array.Length; i++)
            {
                if (i != array[i - 1])
                {
                    missingNumber = array[i] - 1;
                    break;
                }
            }
            return missingNumber;
        }

        //Find the largest and smallest numbers in a given array
        public int FindLargestNumber(int[] array)
        {
            List<int> holder = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                holder.Add(array[i]);
            }
            int largeNumber = holder.Max();
            return largeNumber;
        }

        public int FindSmallestNumber(int[] array)
        {
            List<int> holder = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                holder.Add(array[i]);
            }
            int smallNumber = holder.Min();
            return smallNumber;
        }

        //Fizzbuzz, a classic
        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        // Sum all even numbers in a given array
        public int SumEvenNumbers(int[] test)
        {
            int result = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] % 2 == 0)
                {
                    result += test[i];
                }
            }
            return result;
        }

        // add only the second and third instances
        public string RemoveSecondThird(string test)
        {
            string character = "$";
            int count = 0;
            List<string> holder = test.Split().ToList();
            List<string> result = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < holder.Count(); i++)
            {
                if (holder[i] == character)
                {
                    if (count == 0)
                    {
                        count++;
                    }
                    else
                    {
                        result.Add(holder[i]);
                    }
                }
                else
                {
                    result.Add(holder[i]);
                }
            }
            foreach (var word in result)
            {
                sb.Append(word);
            }
            string resultWord = sb.ToString();
            return resultWord;
        }

        public List<int> ChangeMaker(double price, List<double> payment)
        {
            double quarter = 0.25;
            double dime = 0.1;
            double nickel = 0.05;
            double penny = 0.01;
            int quarterCount = 0;
            int dimeCount = 0;
            int nickelCount = 0;
            int pennyCount = 0;
            List<int> change = new List<int>();
            double amountPaid = 0;
            double difference = 0;
            for (int i = 0; i < payment.Count(); i++)
            {
                amountPaid += payment[i];
            }
            if (amountPaid == price)
            {
                return change;
            }
            else if (price < amountPaid)
            {
                difference = amountPaid - price;
                while (difference >= quarter)
                {
                    quarterCount++;
                    difference -= quarter;
                }
                while (difference >= dime)
                {
                    dimeCount++;
                    difference -= dime;
                }
                while (difference >= nickel)
                {
                    nickelCount++;
                    difference -= nickel;
                }
                while (difference >= penny)
                {
                    pennyCount++;
                    difference -= penny;
                }
                change.Add(pennyCount);
                change.Add(nickelCount);
                change.Add(dimeCount);
                change.Add(quarterCount);
                return change;
            }
            else
            {
                while (amountPaid >= quarter)
                {
                    quarterCount++;
                    amountPaid -= quarter;
                }
                while (amountPaid >= dime)
                {
                    dimeCount++;
                    amountPaid -= dime;
                }
                while (amountPaid >= nickel)
                {
                    nickelCount++;
                    amountPaid -= nickel;
                }
                while (amountPaid >= penny)
                {
                    pennyCount++;
                    amountPaid -= penny;
                }
                change.Add(pennyCount);
                change.Add(nickelCount);
                change.Add(dimeCount);
                change.Add(quarterCount);
                return change;
            }
        }

        public void plusMinus(int[] arr)
        {
            double positiveCount = 0;
            double negativeCount = 0;
            double zeroCount = 0;
            double length = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] == 0)
                {
                    zeroCount++;
                }
                else
                {
                    negativeCount++;
                }
            }
            double positive = positiveCount / length;
            double negative = negativeCount / length;
            double zero = zeroCount / length;
            Console.WriteLine(positive);
            Console.WriteLine(negative);
            Console.WriteLine(zero);
            Console.ReadLine();
        }
    }  
}
