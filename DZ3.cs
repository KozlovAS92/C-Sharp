using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlov.DZ._1._3
{
    class Metod
    {
        public double Metod1(int a, int b, int c, int d)
        {
            double E = (Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2)));
            return(E);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки:\nx1 =");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1 =");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки:\nx2 =");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2 =");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double r = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Выполнение задачи 3.а\n"+"Расстояние между точками: {0:F2}",r);
            Metod Metod = new Metod();
            double F = Metod.Metod1(x1,y1,x2,y2);
            Console.WriteLine("Выполнение задачи 3.б\n" + "Расстояние между точками: {0:F2}", F);
            Console.ReadKey();
        }
    }
}
