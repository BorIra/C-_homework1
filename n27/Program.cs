//Вход: принимает число
// Вывод: сумма цифр введенного числа
using System;       
namespace exp27     
{
    class sumDigit   
    {
        static void Main(string[] str) 
        {
            int setVal()
            {   // ввод числа
                Console.Write("Введите число : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            
            void outputVal(int val, int sum)
            {   // вывод на экран
                Console.Write("Сумма цифр числа {0:d}: {1:d}", val, sum);
            }

            int sumDigit(int digit)
            {   // сумма цифр числа
                int sum = 0;
                for(;digit != 0; digit /= 10)
                {
                    sum += digit % 10;
                }
                return sum;
            }
            
            int digit = setVal();
            outputVal(digit, sumDigit(digit));           
        }
    }
}