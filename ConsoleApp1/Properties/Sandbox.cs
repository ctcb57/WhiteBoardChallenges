using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Properties
{
    class Sandbox
    {
        public int [] A;



        public int AddDoubleDigits(int[] A)
        {
            int result = 0;
            for(int i = 0; i < A.Count(); i++)
            {
                if(A[i] > 9 && A[i] < 100)
                {
                    result += A[i];
                }
            }
            return result;
        }
        // Create method which removes duplicates from an array
        public int [] ReturnNoDuplicates(int [] test)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < test.Length; i++)
            {
                for(int j = 1; j < test.Length; j++)
                {
                    if(test[i] == test[j])
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
    }
}
