//Вход: цифра, обозначающая день недели
// Вывод: является ли день выходным
using System;       
namespace exp15     
{
    class weekend   
    {
        static void Main(string[] str) 
        {
            Console.Write("Введите число: ");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day < 6) Console.Write("Увы будни");
            else if (day > 7) Console.Write("Нет такого дня недели");
            else Console.Write("Ура выходной!");
        } 
    }
}