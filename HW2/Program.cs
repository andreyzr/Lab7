using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите длинну ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double P, S;
            GetParamCub(a, out P, out S);
            Console.WriteLine("Площадь куба равна: {0}",S);
            Console.WriteLine("Периметр куба равен: {0}",P);
            Console.ReadKey();

        }
        static void GetParamCub(int a, out double P, out double S)
        {
            P = a*4;
            S = Math.Pow(a,2);
        }

    }
}
