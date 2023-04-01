//Вход: две точки в трехмерной системе координат
// Вывод: расстояние между точками
using System;       // эти используемые директивы
namespace exp23     // пространство имен
{
    class kybi   
    {
        static void Main(string[] str) 
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Кубы чисел до {0:d}: ", num);

            for (int i = 1; i <= num; i ++)
            {
                Console.Write("{0:d}, ", i*i*i);
            }
        }
    }
}