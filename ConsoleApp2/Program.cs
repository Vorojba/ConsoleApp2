using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1;//Объявление переменной
            Console.Write("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());//Приглашение к вводу
            Console.Write("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());//Приглашение к вводу
            if ((x1 > 0) && (y1 > 0))//Условие  выполняется
            {
                Console.WriteLine("Первая четверть");//вывод на экран
            }
            if ((x1 < 0) && (y1 > 0))
            {
                Console.WriteLine("Вторая четверть");

            }
            if ((x1 < 0) && (y1 < 0))
            {
                Console.WriteLine("Третья четверть");
            }
            if ((x1 > 0) && (y1 < 0))
            {
                Console.WriteLine("Четвертая четверть");
            }
            else Console.WriteLine("Начало координат");//Если условие  не выполняется
            Console.ReadKey();
        }
    }
}
