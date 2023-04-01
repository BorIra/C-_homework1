//Вход: любое число
// Вывод: 3я цифра этого числа, либо сообщение об ее отсутствии
using System;       
namespace exp13     
{
    class Num3   
    {
        static void Main(string[] str) 
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 100) Console.Write("У введенного числа нет третьей цифры");
            else 
            {
               while (num / 1000 != 0)  
               {   // укорачиваем число слева до трехзначного
                   num /= 10;
               } 
               Console.Write(num % 10);
            }

        } 
    }
}