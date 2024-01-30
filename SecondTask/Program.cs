using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main()
        {
            int c1 = 10;  // количество бенгальских огней у Игоря
            int b1 = 2;  // количество потухших огней, необходимых для создания нового
            Console.WriteLine(TotalBurningTime(c1, b1));  // Вывод: общее время горения
            Console.ReadLine();
        }

        static int TotalBurningTime(int c1, int b1) 
        {
            int total_time = 0;
            int Burned = 0;
            while (c1 > 0) //Цикл до тех пор, пока у Игоря не закончатся огни
            {
                total_time += 2 * c1; //Время находим как количество огней умноженное на время горения одного
                Burned += c1; //Это количество соженных огней
                c1 = Burned / b1; //Целое количество огней, которое можно получить из соженных 
                Burned %= b1; // Оставшееся количество соженных
            }
            return total_time;
        }
    }
}
