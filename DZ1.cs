using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlov.DZ1._1
{   
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
