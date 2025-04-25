using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(a => int.Parse(a))
                .ToArray();

            List<int> greatNumbers = new List<int>();

            
           
            for (int i = 0; i < arr.Length; i++)
            {
                bool isGreatNumber = true;
                int currentElement = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(currentElement <= arr[j])
                    {
                        isGreatNumber = false;
                        break;
                    }
                }

                if (isGreatNumber == true)
                {
                    greatNumbers.Add(currentElement);
                }
            }
            Console.WriteLine(String.Join(" ", greatNumbers));
        }
    }
}
