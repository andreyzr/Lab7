using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());
            CalcSum(a, b,c);
            Console.ReadKey();

        }
        static void CalcSum(params int[] number)
        {
            int S = 0;
            foreach (int n in number)
                S += n;
            Console.WriteLine(S);
        }

    }
}
