using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина окружности радиуса {0} равна {1:F2}", radius, Circle.Lenght(radius));
            Console.WriteLine("Площадь круга радиуса {0} равна {1:F2}", radius, Circle.Area(radius));

            Console.WriteLine("Введите X координату центра окружности");
            double x0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y координату центра окружности");
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X точки");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y точки");
            double y = Convert.ToDouble(Console.ReadLine());

            Circle.CirclePoint(x0, y0, x, y,radius);
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public static double Lenght(double rad)
        {
            return 2 * Math.PI * rad;

        }
        public static double Area(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }
        public static void CirclePoint(double x, double y, double x0, double y0, double rad)
        {
            if (Math.Abs(x - x0) <= rad || Math.Abs(y - y0) <= rad)
            {
                Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит окружности");
            }
        }
    }
}
