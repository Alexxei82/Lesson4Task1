using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Task1
{
    class Program
    {
        static void Main(string[] args)
        //Возведение в квадрат положительного целого числа по формуле N2=1+3+5+...(2*N-1)
        {
            Console.WriteLine("Введите число > 0");
               long n = Convert.ToInt64(Console.ReadLine()), sum = 0, x=1;
            if (n>0)
            {
                for (long i = 1; i < (2 * n - 1) + 1; i += 2)
                Console.WriteLine("Квадрат {0}равен {1}", x++, sum += i);
            }
            else Console.WriteLine("Вы ввели число меньше либо равное 0");
                       
            Console.ReadKey();

            
        }
    }
}
