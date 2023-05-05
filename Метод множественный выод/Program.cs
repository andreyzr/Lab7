using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_множественный_выод
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double P, S;
            GetParam( a, b,out P, out S);
            Console.WriteLine(S);
            Console.ReadKey();

        }
        static void GetParam( int a, int b,out double P, out double S)
        {
            P=a+b+Math.Sqrt(a*a+b*b);
            S = ((double)a) * b / 2;
        }
    }
}
