using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozlovDZ1
{
    class Metod1
    {
        public void Metod11(int a, int b) { Console.WriteLine("a = {0}\nb = {1}", a, b); }
    }
    class Metod
    {
        public double Metod1(int a, int b, int c, int d)
        {
            double E = (Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2)));
            return (E);
        }
        class Program
        {
            static void Main(string[] args)
            {
                //Задача 1
                Console.Write("Введите ваше имя:");
                string a = Console.ReadLine();
                Console.Write("Введите вашу фамилию:");
                string b = Console.ReadLine();
                Console.Write("Введите ваш возраст:");
                string c = Console.ReadLine();
                Console.Write("Введите ваш рост:");
                string d = Console.ReadLine();
                Console.Write("Введите ваш вес:");
                string e = Console.ReadLine();
                string f = (" ");
                Console.Write("Выполнение задачи 1.а\n" + a + f + b + f + c + f + d + f + e);
                Console.Write("\nВыполнение задачи 1.б\n{0} {1} {2} {3} {4}", a, b, c, d, e);
                string g = "\nВыполнение задачи 1.в\n";
                Console.WriteLine($"{g + a + f + b + f + c + f + d + f + e}");
                Console.ReadKey();

                //задача 2
                Console.WriteLine("Для расчет ИМТ введите ваш вес: ");
                string aa = Console.ReadLine();
                double m = Convert.ToDouble(aa);
                Console.WriteLine("\nДля расчет ИМТ введите ваш рост в метрах: ");
                string bb = Console.ReadLine();
                double h = Convert.ToDouble(bb);
                double I = m / (h * h);
                Console.WriteLine("\nВаш индекс массы тела: {0}", I);
                Console.ReadKey();

                //задача 3
                Console.WriteLine("Введите координаты первой точки:\nx1 =");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y1 =");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координаты второй точки:\nx2 =");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y2 =");
                int y2 = Convert.ToInt32(Console.ReadLine());
                double r = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
                Console.WriteLine("Выполнение задачи 3.а\n" + "Расстояние между точками: {0:F2}", r);
                Metod Metod = new Metod();
                double F = Metod.Metod1(x1, y1, x2, y2);
                Console.WriteLine("Выполнение задачи 3.б\n" + "Расстояние между точками: {0:F2}", F);
                Console.ReadKey();

                //задача 4
                int aaa = 1;
                int bbb = 2;
                int ccc;
                Metod1 Metod1 = new Metod1();
                Metod1.Metod11(aaa, bbb);
                Console.WriteLine("Выполнение задачи 4.а\n");
                ccc = aaa;
                aaa = bbb;
                bbb = ccc;
                Metod1.Metod11(aaa, bbb);
                Console.WriteLine("\nВыполнение задачи 4.b\n");
                aaa = aaa + bbb;
                bbb = aaa - bbb;
                aaa = aaa - bbb;
                Metod1.Metod11(aaa, bbb);
                Console.ReadKey();
            }
        }
    }
}
