using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlov.DZ._1._4
{
    class Metod
    {
        public void Metod1(int a, int b) { Console.WriteLine("a = {0}\nb = {1}", a, b); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c;
            Metod Metod = new Metod();
            Metod.Metod1(a, b);
            Console.WriteLine("Выполнение задачи 4.а\n");
            c = a;
            a = b;
            b = c;
            Metod.Metod1(a, b);
            Console.WriteLine("\nВыполнение задачи 4.b\n");
            a = a + b;
            b = a - b;
            a = a - b;
            Metod.Metod1(a, b);
            Console.ReadKey();
        }
    }
}
