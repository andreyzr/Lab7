using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static double GetSquare(double x, double y, double z)
        {
            double p=(x+y+z)/2;
            return Math.Sqrt(p*(p-x)*(p-y)*(p-z));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выведите катет первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetSquare(x1, y1,z1);
            Console.WriteLine("Выведите катеты второго  треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetSquare(x2, y2, z2);

            if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника больше и равна: {0:f2}",s1);
            }
            else
                if (s1 < s2)
                Console.WriteLine("Площадь второго треугольника больше и равны: {0:f2}", s2);
            else
                Console.WriteLine("Площади двух треугольников  равны:{0}",s1);
            Console.ReadKey();
        }
    }
}
