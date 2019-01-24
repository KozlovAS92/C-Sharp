using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlov.DZ._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для расчет ИМТ введите ваш вес: ");
            string a = Console.ReadLine();
            double m = Convert.ToDouble(a);
            Console.WriteLine("\nДля расчет ИМТ введите ваш рост в метрах: ");
            string b = Console.ReadLine();
            double h = Convert.ToDouble(b);
            double I = m/(h*h);
            Console.WriteLine("\nВаш индекс массы тела: {0}",I);
            Console.ReadKey();
            
        }
    }
}
