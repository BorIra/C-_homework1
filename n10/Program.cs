//Вход: трехзначное число
// Вывод: 2я цифра этого числа
using System;       // эти используемые директивы
namespace exp10     // пространство имен
{
    class Num2   
    {
        static void Main(string[] str) 
        {
            Console.Write("Введите трехзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 100 && num < 1000) 
                Console.Write((num/10)%10);
            else Console.Write("Введено не трехзначное число");
        }
    }
}