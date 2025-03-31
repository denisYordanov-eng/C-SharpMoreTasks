using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();

            int index = 0;
            long sum = 0L;
            while (true)
            {
                int tempIndex = index;
                sum += number[index];
                index += number[index];

                if(index > number.Length - 1)
                {
                    index = tempIndex - number[tempIndex];
                    if(index < 0)
                    {
                        break;
                    }
                }
                   
            }
            Console.WriteLine(sum);
        }
    }
}
