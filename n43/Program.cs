//Вход: k1, b1, k2, b2, где каждая пара k и b описывают прямую y=k*x+b
// Вывод: точка пересечения прямых
using System;       
namespace exp43     
{
    class Peresechenie   
    {
        static int setVal(string str)
        {  
            Console.Write("Введите значение {0:s} : ", str);
            return Convert.ToInt32(Console.ReadLine());
        }

        static double[] findPeresechenie(double k1, double b1, double k2, double b2)
        {
            double[] point = new double[2];
            point[0] =  (b2 - b1)/(k1 - k2);
            point[1] = k2 * point[0] + b2;
            return point;
        }

        static void printPoint(double[] p)
        {
            Console.Write("точка пересечения ({0:n},{1:n})", p[0], p[1]);
        }

        static void Main(string[] str) 
        {
            double k1 = setVal("k1");
            double b1 = setVal("b1");
            double k2 = setVal("k2");
            double b2 = setVal("b2");
            
            double[] point = findPeresechenie(k1, b1, k2, b2);
            printPoint(point);
        }
    }
}