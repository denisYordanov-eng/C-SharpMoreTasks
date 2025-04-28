using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(a => int.Parse(a))
                .ToArray();


            int magicNumber = int.Parse(Console.ReadLine());
            List<int> magNumbers = new List<int>();
            bool  isMagicSum =  false;
            int number = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                //int number = 0;
                //int sum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    number = arr[j];
                    sum = currentNumber + number;
                    if (sum == magicNumber)
                    {
                        isMagicSum = true;
                        Console.WriteLine("{0} {1}", currentNumber, number);
                    }
                }
               
            }
        }   
    }
}
