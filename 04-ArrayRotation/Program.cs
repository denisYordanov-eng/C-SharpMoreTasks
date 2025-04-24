using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(a => int.Parse(a))
                .ToArray();

            int rotation = int.Parse(Console.ReadLine());
            int firstElement = 0;
            for (int i = 0; i < rotation; i++)
            {
                firstElement = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = firstElement;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
