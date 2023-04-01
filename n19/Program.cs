//Вход: пятизначное число
// Вывод: определить является ли числа палиндромом
using System;       
namespace exp19     
{
    class palindrom   
    {
        static void Main(string[] str) 
        {
            Console.Write("Введите пятизначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 10000 || num >= 100000) Console.Write("Введено не пятизначное число");
            else 
            {
                int n1 = num / 10000;
                int n2 = (num / 1000) % 10;
                int n4 = (num / 10) % 10;
                int n5 = num % 10;
                if ((n1 == n5) && (n2 == n4)) Console.Write("Введеное число является палиндромом");
                else Console.Write("Введеное число не является палиндромом");
            }
        } 
    }
}