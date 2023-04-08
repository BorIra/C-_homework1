//Вход: Два числа а и b
// Вывод: возвести а в степень b через цикл
using System;       
namespace exp23     
{
    class stepen   
    {
        static void Main(string[] str) 
        {
            int setVal(string text)
            {   // ввод числа
                Console.Write("Введите число " + text + ": ");
                return Convert.ToInt32(Console.ReadLine());
            }
            
            int myPow(int a, int b)
            {   // возведение а в степень b
                if (b == 0) return 1;
                
                int pow = a;
                for(int i = 2; i <= b; i++)
                {
                    pow *=   a;
                }
                return pow;
            }

            void outputVal(int a, int b, int val)
            {   // вывод на экран
                Console.Write("{0:d} ^ {1:d} = {2:d} ", a, b, val);
            }
            
            int a = setVal("\'a\'");
            int b = setVal("\'b\'");

            outputVal(a, b, myPow(a, b));           
        }
    }
}