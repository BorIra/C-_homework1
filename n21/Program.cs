//Вход: две точки в трехмерной системе координат
// Вывод: расстояние между точками
using System;       
namespace exp21     
{
    class koordinaty   
    {
        static void Main(string[] str)  
        {
            Console.WriteLine("Введите координаты первой точки");
            
            Console.Write("X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z1: ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите координаты второй точки.");
            
            Console.Write("X2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z2: ");
            int z2 = Convert.ToInt32(Console.ReadLine());

            double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
            Console.Write("Расстояние между точками: {0:n}", dist);
        }
    }
}