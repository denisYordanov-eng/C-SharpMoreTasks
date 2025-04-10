using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] passagers = new int[n];
            long sum = 0L;
            for (int i = 0; i < n; i++)
            {
                passagers[i] = int.Parse(Console.ReadLine());
                sum += passagers[i];
            }
            Console.WriteLine(String.Join(" ", passagers));
            Console.WriteLine(sum);
        }
    }
}
