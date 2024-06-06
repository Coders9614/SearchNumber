using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SearchNumber
{
    internal class Program
    {
       static int Search(int[] arr, int num)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {   if(arr[i] == num)
                    return i;
            }
            return -1;
   
        }
        static void Main(string[] args)
        {
            //example 1
            int[] numbers = { 1, 5, 3 };
            int target = 5;

            int result = Search(numbers, target);
            Console.WriteLine($"Index of {target}: {result}");
            //example 2
            int[] numbers2 = { 9, 8, 3 };
            int target2 = 3;

            int result2 = Search(numbers2, target2);
            Console.WriteLine($"Index of {target2}: {result2}");
            //example 3
            int[] numbers3 = { 1, 2, 3 };
            int target3 = 4;

            int result3 = Search(numbers3, target3);
            Console.WriteLine($"Index of {target3}: {result3}");
            Console.ReadKey();
        }
    }
}
