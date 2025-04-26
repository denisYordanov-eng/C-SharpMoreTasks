using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(a => int.Parse(a))
                .ToArray();
             
           if(arr.Length <= 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for(int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}